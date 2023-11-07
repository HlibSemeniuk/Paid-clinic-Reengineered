using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Examination : IEntity
    {
        public int ID { get; set; }
        public string Symptopms { get; set; }
        public string Diagnosis { get; set; }
        public int TreatmentID { get; set; }
        public virtual Treatment Treatment { get; set; }
    }
}
