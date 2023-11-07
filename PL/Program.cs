using AutoMapper;
using BLL.AutoMapper;
using BLL.DTO;
using BLL.Services;
using DAL;
using DAL.EF;
using DAL.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddAutoMapper(typeof(MappingProfile));
            var provider = services.BuildServiceProvider();
            var mapper = provider.GetService<IMapper>();

            var clinicContext = new ClinicContext();
            var unitOfWork = new UnitOfWork(clinicContext);

            Application.Run(new StartUpMenu(unitOfWork, mapper));
        }
    }
}