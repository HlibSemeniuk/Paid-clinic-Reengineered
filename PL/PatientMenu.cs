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
    public partial class PatientMenu : Form
    {
        PatientDTO patient;

        AppointmentService appointmentService;
        DoctorService doctorService;
        ExaminationService examinationService;
        PatientService patientService;
        TreatmentService treatmentService;

        public PatientMenu(PatientDTO patientDTO, AppointmentService appointmentService, DoctorService doctorService, ExaminationService examinationService, PatientService patientService, TreatmentService treatmentService)
        {
            patient = patientDTO;

            this.appointmentService = appointmentService;
            this.doctorService = doctorService;
            this.examinationService = examinationService;
            this.patientService = patientService;
            this.treatmentService = treatmentService;

           
            InitializeComponent();
            label1.Text = $"Вітаємо, {patientDTO.Name}!";
        }
    }
}
