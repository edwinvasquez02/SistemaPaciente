using AutoMapper;
using SistemaPaciente.Core.Application.Interfaces.Repositories;
using SistemaPaciente.Core.Application.Interfaces.Services;
using SistemaPaciente.Core.Application.ViewModels.RolViewModels;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Services
{
    public class RolServices : GenericService<SaveRolViewModel, RolViewModel, Rol>, IRolServices
    {
        public RolServices(IMapper mapper, IRolRepository rolRepository) : base(mapper, rolRepository)
        {
        }
    }
}
