using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClinicContext _context;

        public UnitOfWork(ClinicContext context)
        {
            _context = context;
            Doctors = new DoctorRepository(_context);
            Patients = new PatientRepository(_context);
            Appointments = new AppointmentRepository(_context);
            Examinations = new ExaminationRepository(_context);
            Treatments = new TreatmentRepository(_context);
        }

        public IGenericRepository<Doctor> Doctors { get; private set; }

        public IGenericRepository<Patient> Patients { get; private set; }

        public IGenericRepository<Appointment> Appointments { get; private set; }

        public IGenericRepository<Examination> Examinations { get; private set; }

        public IGenericRepository<Treatment> Treatments { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
