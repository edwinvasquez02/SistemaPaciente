using SistemaPaciente.Core.Application.Interfaces.Repositories;
using SistemaPaciente.Core.Domain.Entities;
using SistemaPaciente.Infraestructure.Persistence.Context;

namespace SistemaPaciente.Infraestructure.Persistence.Repositories
{
    public class LabTestRepository : GenericRepositoryAsync<LabTests>, ILabTestRepository
    {
        public LabTestRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
