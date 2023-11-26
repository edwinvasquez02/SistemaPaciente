using SistemaPaciente.Core.Application.ViewModels.LabResultViewModels;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Interfaces.Services
{
    public interface ILabResultServices:IGenericService<SaveLabResultViewModel,LabResultViewModel,PatientLabTests>
    {
        Task<List<LabResultViewModel>> GetByFiltersAsync(FilterLabResultViewModel filter);
        Task DeleteByIdAppoinment(int id);
        Task<List<LabResultViewModel>> GetByIdAppoinment(int id);
        Task<List<LabResultViewModel>> GetTestCompleted(int id);
    }
}
