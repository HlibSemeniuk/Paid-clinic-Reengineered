using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public abstract class UserDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Password { get; set; }
        public virtual ICollection<AppointmentDTO> Appointments { get; set; }
    }
}
