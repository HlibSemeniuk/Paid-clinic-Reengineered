using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Appointment : IEntity
    { 
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public bool IsHappened { get; set; }
        public int DoctorID { get; set; }
        public virtual Doctor Doctor { get; set; }

        public int PatientID { get; set; }
        public virtual Patient Patient { get; set; }

        public int? ExaminationID { get; set; }
        public virtual Examination? Examination { get; set; }
    }
}
