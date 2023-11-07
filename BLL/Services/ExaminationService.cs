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
    public class ExaminationService
    {
        private readonly IMapper _mapper;
        private IUnitOfWork Database { get; set; }

        public ExaminationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            Database = unitOfWork;
            _mapper = mapper;
        }

        public void Add(ExaminationDTO examinationDTO)
        {
            var examination = _mapper.Map<Examination>(examinationDTO);

            examination.Treatment = Database.Treatments.GetLast();

            Database.Examinations.Insert(examination);
            Database.Save();
        }

        public List<ExaminationDTO> GetAllCheckUps()
        {
            var examination = Database.Examinations.GetAll();
            return _mapper.Map<List<ExaminationDTO>>(examination);
        }

        public ExaminationDTO GetCheckUp(int id)
        {
            return _mapper.Map<ExaminationDTO>(Database.Examinations.GetByID(id));
        }

        public void ChangeData(ExaminationDTO examinationDTO)
        {
            var examination = Database.Examinations.GetByID(examinationDTO.ID);
            _mapper.Map(examinationDTO, examination);

            Database.Examinations.Update(examination);
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Examinations.Delete(id);
            Database.Save();
        }
    }
}
