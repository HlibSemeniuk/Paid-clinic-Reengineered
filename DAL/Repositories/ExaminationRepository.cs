using DAL.EF;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ExaminationRepository : GenericRepository<Examination>
    {
        public ExaminationRepository(ClinicContext context) : base(context)
        {
        }
    }
}
