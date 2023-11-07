using AutoMapper;
using BLL.DTO;
using BLL.AutoMapper;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DoctorService
    {
        private readonly IMapper _mapper;
        private IUnitOfWork Database { get; set; }
        

        public DoctorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            Database = unitOfWork;
            _mapper = mapper;
        }

        public void Add(DoctorDTO doctorDTO)
        {
            Doctor doctor = _mapper.Map<Doctor>(doctorDTO);

            Database.Doctors.Insert(doctor);
            Database.Save();
        }

        public List<DoctorDTO> GetDoctors()
        {
            var doctors = Database.Doctors.GetAll();
            return _mapper.Map<List<DoctorDTO>>(doctors);
        }

        public DoctorDTO GetDoctor(int id)
        {
            return _mapper.Map<DoctorDTO>(Database.Doctors.GetByID(id));
        }

        public void ChangeData(DoctorDTO doctorDTO)
        {
            Doctor doctor = Database.Doctors.GetByID(doctorDTO.ID);
            _mapper.Map(doctorDTO, doctor);

            Database.Doctors.Update(doctor);
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Doctors.Delete(id);
            Database.Save();
        }
    }
}
