using AutoMapper;
using BLL.DTO;
using DAL.Entities;

namespace BLL.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Patient, PatientDTO>().ReverseMap();
            CreateMap<Doctor, DoctorDTO>().ReverseMap();
            CreateMap<Appointment, AppointmentDTO>().ReverseMap();
            CreateMap<Examination, ExaminationDTO>().ReverseMap();
            CreateMap<Treatment, TreatmentDTO>().ReverseMap();
        }
    }
}