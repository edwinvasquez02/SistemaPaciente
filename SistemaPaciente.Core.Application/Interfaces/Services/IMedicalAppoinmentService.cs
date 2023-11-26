using SistemaPaciente.Core.Application.ViewModels.MedicalViewModels;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Interfaces.Services
{
    public interface IMedicalAppoinmentService:IGenericService<SaveMedicalViewModel,MedicalViewModel,MedicalAppointment>
    {
        Task<List<MedicalViewModel>> GetAllViewModelWithInclude();
    }
}
