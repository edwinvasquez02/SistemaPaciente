using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Interfaces.Repositories
{
    public interface IAppoinmentStatusRepository : IGenericRepositoryAsync<AppoinmentStatus>
    {
        Task<int> GetAppoinmetIdbyName(string name);
    }
}
