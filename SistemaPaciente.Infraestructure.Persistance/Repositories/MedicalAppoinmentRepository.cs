using SistemaPaciente.Core.Application.Interfaces.Repositories;
using SistemaPaciente.Core.Domain.Entities;
using SistemaPaciente.Infraestructure.Persistence.Context;

namespace SistemaPaciente.Infraestructure.Persistence.Repositories
{
    public class MedicalAppoinmentRepository : GenericRepositoryAsync<MedicalAppointment>, IMedicalAppoinmentRepository
    {
        public MedicalAppoinmentRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
