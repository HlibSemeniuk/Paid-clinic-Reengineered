
using AutoMapper;
using BLL.AutoMapper;
using BLL.DTO;
using BLL.Services;
using DAL;
using DAL.EF;
using DAL.Entities;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddAutoMapper(typeof(MappingProfile));
var provider = services.BuildServiceProvider();
var mapper = provider.GetService<IMapper>();

ClinicContext clinicContext = new ClinicContext();
UnitOfWork unitOfWork = new UnitOfWork(clinicContext);

AppointmentService appointmentService = new AppointmentService(unitOfWork, mapper);
DoctorService doctorService = new DoctorService(unitOfWork, mapper);
ExaminationService examinationService = new ExaminationService(unitOfWork, mapper);
PatientService patientService = new PatientService(unitOfWork,mapper);
TreatmentService treatmentService = new TreatmentService(unitOfWork, mapper);
