using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class TreatmentDTO
    {
        public int ID { get; set; }
        public string Recommendations { get; set; }
        public string Medicines { get; set; }
        public decimal TreatmentPrice { get; set; }
        public float SocialDiscountPercent { get; set; }
    }
}
