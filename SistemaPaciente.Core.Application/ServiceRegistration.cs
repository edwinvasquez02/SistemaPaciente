﻿using SistemaPaciente.Core.Application.Interfaces.Services;
using SistemaPaciente.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SistemaPaciente.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            #region Services
            services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            services.AddTransient<IRolServices, RolServices>();
            services.AddTransient<IUserServices, UserServices>();
            services.AddTransient<IPatientService, PatientService>();
            services.AddTransient<IDoctorServices, DoctorService>();
            services.AddTransient<ILabTestServices, LabTestServices>();
            services.AddTransient<IAppoinmetStatusService, AppoinmentStatusService>();
            services.AddTransient<IMedicalAppoinmentService, MedicalAppoinmentService>();
            services.AddTransient<ILabResultServices, LabResultServices>();

            #endregion
        }
    }
}