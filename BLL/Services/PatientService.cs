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
    public class PatientService
    {
        private readonly IMapper _mapper;
        private IUnitOfWork Database { get; set; }

        public PatientService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            Database = unitOfWork;
            _mapper = mapper;
        }

        public void Add(PatientDTO patientDTO)
        {
            Patient patient = _mapper.Map<Patient>(patientDTO);

            Database.Patients.Insert(patient);
            Database.Save();
        }

        public List<PatientDTO> GetPatients() 
        {
            var patients = Database.Patients.GetAll();
            return _mapper.Map<List<PatientDTO>>(patients);
        }

        public PatientDTO GetPatient(int id)
        {
            return _mapper.Map<PatientDTO>(Database.Patients.GetByID(id));
        }

        public void ChangeData(PatientDTO patientDTO)
        {
            Patient patient = Database.Patients.GetByID(patientDTO.ID);
            _mapper.Map(patientDTO, patient);

            Database.Patients.Update(patient);
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Patients.Delete(id);
            Database.Save();
        }
    }
}
