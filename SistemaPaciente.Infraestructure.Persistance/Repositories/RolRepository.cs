using SistemaPaciente.Core.Application.Interfaces.Repositories;
using SistemaPaciente.Core.Domain.Entities;
using SistemaPaciente.Infraestructure.Persistence.Context;

namespace SistemaPaciente.Infraestructure.Persistence.Repositories
{
    public class RolRepository : GenericRepositoryAsync<Rol>, IRolRepository
    {
        public RolRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
