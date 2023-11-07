using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ExaminationDTO
    {
        public int ID { get; set; }
        public string Symptopms { get; set; }
        public string Diagnosis { get; set; }
        public int TreatmentID { get; set; }
        public virtual TreatmentDTO Treatment { get; set; }
    }
}
