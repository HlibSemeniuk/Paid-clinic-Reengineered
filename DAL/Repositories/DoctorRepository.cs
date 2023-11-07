using DAL.EF;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DoctorRepository : GenericRepository<Doctor>
    {
        public DoctorRepository(ClinicContext context) : base(context)
        {
        }
    }
}
