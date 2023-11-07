using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TreatmentService
    {
        private readonly IMapper _mapper;
        private IUnitOfWork Database { get; set; }


        public TreatmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            Database = unitOfWork;
            _mapper = mapper;
        }

        public void Add(TreatmentDTO treatmentDTO)
        {
            var treatment = _mapper.Map<Treatment>(treatmentDTO);

            Database.Treatments.Insert(treatment);
            Database.Save();
        }

        public List<TreatmentDTO> GetTreatments() 
        {
            var treatment = Database.Treatments.GetAll();
            return _mapper.Map<List<TreatmentDTO>>(treatment);
        }

        public TreatmentDTO GetTreatment(int id)
        {
            return _mapper.Map<TreatmentDTO>(Database.Treatments.GetByID(id));
        }

        public void ChangeData(TreatmentDTO treatmentDTO)
        {
            var treatment = Database.Treatments.GetByID(treatmentDTO.ID);
            _mapper.Map(treatmentDTO, treatment);

            Database.Treatments.Update(treatment);
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Treatments.Delete(id);
            Database.Save();
        }
    }
}
