using SistemaPaciente.Core.Application.Interfaces.Repositories;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Interfaces.Repositories
{
    public interface IDoctorRepository:IGenericRepositoryAsync<Doctor>
    {
    }
}
