using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AppointmentService
    {
        private readonly IMapper _mapper;
        private IUnitOfWork Database { get; set; }


        public AppointmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            Database = unitOfWork;
            _mapper = mapper;
        }

        public void Add(AppointmentDTO appointmentDTO)
        {
            Appointment appointment = _mapper.Map<Appointment>(appointmentDTO);

            appointment.Patient = Database.Patients.GetByID(appointment.Patient.ID);
            appointment.Doctor = Database.Doctors.GetByID(appointment.Doctor.ID);
            appointment.Examination = Database.Examinations.GetLast();

            Database.Appointments.Insert(appointment);
            Database.Save();
        }

        public List<AppointmentDTO> GetAppointments() 
        {
            var appointments = Database.Appointments.GetAll();
            return _mapper.Map<List<AppointmentDTO>>(appointments);
        }

        public List<AppointmentDTO> GetUserAppointments(int userID, bool isDoctor)
        {
            var appointments = isDoctor
                ? Database.Appointments.Find(a => a.DoctorID == userID)
                : Database.Appointments.Find(a => a.PatientID == userID);
            return _mapper.Map<List<AppointmentDTO>>(appointments);
        }

        public AppointmentDTO GetAppointment(int id)
        {
            return _mapper.Map<AppointmentDTO>(Database.Appointments.GetByID(id));
        }

        public void ChangeData(AppointmentDTO appointmentDTO)
        {
            Appointment appointment = Database.Appointments.GetByID(appointmentDTO.ID);
            _mapper.Map(appointmentDTO, appointment);

            Database.Appointments.Update(appointment);
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Appointments.Delete(id);
            Database.Save();
        }
    }
}
