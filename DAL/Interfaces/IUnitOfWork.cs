using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Doctor> Doctors { get; }
        IGenericRepository<Patient> Patients { get; }
        IGenericRepository<Appointment> Appointments { get; }
        IGenericRepository<Examination> Examinations { get; }
        IGenericRepository<Treatment> Treatments { get; }

        void Save();
    }
}
