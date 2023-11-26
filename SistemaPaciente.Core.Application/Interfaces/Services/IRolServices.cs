using SistemaPaciente.Core.Application.ViewModels.RolViewModels;
using SistemaPaciente.Core.Application.ViewModels.RolViewModels;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Interfaces.Services
{
    public interface IRolServices:IGenericService<SaveRolViewModel,RolViewModel, Rol>
    {
    }
}
