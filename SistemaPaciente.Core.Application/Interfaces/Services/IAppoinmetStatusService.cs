using SistemaPaciente.Core.Application.ViewModels.AppoinmentStatusViewModels;
using SistemaPaciente.Core.Application.ViewModels.AppoinmentStatusViewModels;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Interfaces.Services
{
    public interface IAppoinmetStatusService:IGenericService<SaveAppoinmentViewModel,AppoinmentStatusViewModel,AppoinmentStatus>
    {
        Task<int> GetAppoinmetIdbyName(string name);
    }
}
