using SistemaPaciente.Core.Application.Interfaces.Repositories;
using SistemaPaciente.Core.Domain.Entities;
using SistemaPaciente.Infraestructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace SistemaPaciente.Infraestructure.Persistence.Repositories
{
    public class PatientRepository : GenericRepositoryAsync<Patient>, IPatientReposity
    {
        public PatientRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
