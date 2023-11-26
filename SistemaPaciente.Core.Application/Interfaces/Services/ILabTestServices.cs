using SistemaPaciente.Core.Application.ViewModels.LabTestViewModels;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Interfaces.Services
{
    public interface ILabTestServices:IGenericService<SaveLabTestViewModel,LabTestViewModel,LabTests>
    {
    }
}
