using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class AppointmentDTO
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public bool IsHappened { get; set; }
        public int MedicalCheckUpID { get; set; }
        public int DoctorID { get; set; }
        public virtual DoctorDTO Doctor { get; set; }

        public int PatientID { get; set; }
        public virtual PatientDTO Patient { get; set; }

        public int? ExaminationID { get; set; }
        public virtual ExaminationDTO? Examination { get; set; }
    }
}
