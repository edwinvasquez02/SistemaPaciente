using SistemaPaciente.Core.Application.Interfaces.Repositories;
using SistemaPaciente.Core.Domain.Entities;
using SistemaPaciente.Infraestructure.Persistence.Context;

namespace SistemaPaciente.Infraestructure.Persistence.Repositories
{
    public class DoctorRepository : GenericRepositoryAsync<Doctor>, IDoctorRepository
    {
        public DoctorRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
