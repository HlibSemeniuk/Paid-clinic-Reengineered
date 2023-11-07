using AutoMapper;
using BLL.DTO;
using BLL.Services;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace PL
{
    public partial class StartUpMenu : Form
    {
        AppointmentService appointmentService;
        DoctorService doctorService;
        ExaminationService examinationService;
        PatientService patientService;
        TreatmentService treatmentService;

        public StartUpMenu(IUnitOfWork unitOfWork, IMapper mapper)
        {
            appointmentService = new AppointmentService(unitOfWork, mapper);
            doctorService = new DoctorService(unitOfWork, mapper);
            examinationService = new ExaminationService(unitOfWork, mapper);
            patientService = new PatientService(unitOfWork, mapper);
            treatmentService = new TreatmentService(unitOfWork, mapper);

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_SignIN_Click(object sender, EventArgs e)
        {

            if (!textBox_Name.Text.Equals("") && !textBox_Password.Equals(""))
            {
                var isFound = false;
                var doctors = doctorService.GetDoctors();

                var Name = "";
                var Password = "";
                var Doctor = new DoctorDTO();
                var Patient = new PatientDTO();

                foreach (var doctor in doctors)
                {
                    if (doctor.Name.Equals(textBox_Name.Text))
                    {
                        isFound = true;
                        Name = doctor.Name;
                        Password = doctor.Password;
                        Doctor = doctor;
                        break;
                    }
                }

                if (!isFound)
                {
                    var patients = patientService.GetPatients();

                    foreach (var patient in patients)
                    {
                        if (patient.Name.Equals(textBox_Name.Text))
                        {
                            isFound = true;
                            Name = patient.Name;
                            Password = patient.Password;
                            Patient = patient;
                            break;
                        }
                    }
                }

                if (!isFound)
                {
                    MessageBox.Show($"Користувача {textBox_Name.Text} не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!textBox_Password.Text.Equals(Password))
                    {
                        MessageBox.Show("Неправильний пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (!Doctor.Password.IsNullOrEmpty())
                        {
                            DoctorMenu doctorMenu = new DoctorMenu(Doctor, appointmentService, doctorService, examinationService, patientService, treatmentService);
                            this.Hide();
                            doctorMenu.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            PatientMenu patientMenu = new PatientMenu(Patient, appointmentService, doctorService, examinationService, patientService, treatmentService);
                            this.Hide();
                            patientMenu.ShowDialog();
                            this.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Усі дані не введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}