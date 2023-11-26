using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaPaciente.Core.Application.Interfaces.Repositories;
using SistemaPaciente.Infraestructure.Persistence.Context;
using SistemaPaciente.Infraestructure.Persistence.Repositories;

namespace SistemaPaciente.Infraestructure.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region Contexts
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<ApplicationContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
               m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
            }
            #endregion

            #region Repositories
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IUserRepository, UserRepositoryAsync>();
            services.AddTransient<IRolRepository, RolRepository>();
            services.AddTransient<IPatientReposity, PatientRepository>();
            services.AddTransient<IDoctorRepository, DoctorRepository>();
            services.AddTransient<ILabTestRepository, LabTestRepository>();
            services.AddTransient<IAppoinmentStatusRepository, AppoinmentStatusRepository>();
            services.AddTransient<IMedicalAppoinmentRepository, MedicalAppoinmentRepository>();
            services.AddTransient<ILabResultRepository, LabResultRepository>();

            #endregion
        }
    }
}
