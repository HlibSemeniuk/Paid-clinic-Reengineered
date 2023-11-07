using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class DoctorMenu : Form
    {
        DoctorDTO doctor;

        AppointmentService appointmentService;
        DoctorService doctorService;
        ExaminationService examinationService;
        PatientService patientService;
        TreatmentService treatmentService;

        public DoctorMenu(DoctorDTO doctorDTO, AppointmentService appointmentService, DoctorService doctorService, ExaminationService examinationService, PatientService patientService, TreatmentService treatmentService)
        {
            doctor = doctorDTO;

            this.appointmentService = appointmentService;
            this.doctorService = doctorService;
            this.examinationService = examinationService;
            this.patientService = patientService;
            this.treatmentService = treatmentService;

            InitializeComponent();
        }

        private void DoctorMenu_Load(object sender, EventArgs e)
        {
            label1.Text = $"Вітаємо, {doctor.Name}!";
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Name", "Ім'я та прізвище пацієнта");
            dataGridView1.Columns.Add("Date", "Дата");
            
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            // TODO: створити метод в BLL для отриимання записів за ID лікаря
            List<AppointmentDTO> appointments = appointmentService.GetAppointments();
            appointments = appointments.FindAll(a => a.DoctorID == doctor.ID);


            foreach (var appointment in appointments) // TODO: дізнатись чому в appointments відсутні об'єкти Patient
            {
                var patientName = patientService.GetPatient(appointment.PatientID).Name;
                dgv.Rows.Add(patientName, appointment.Date.ToString("dd.MM.yyyy о HH:mm"));
            }
        }
    }
}
