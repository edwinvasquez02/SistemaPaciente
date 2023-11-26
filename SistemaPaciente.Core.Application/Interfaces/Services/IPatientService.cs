using SistemaPaciente.Core.Application.Interfaces.Interfaces;
using SistemaPaciente.Core.Application.ViewModels.PatientViewModels;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Interfaces.Services
{
    public interface IPatientService : IGenericService<SavePatientViewModel, PatientViewModel, Patient>,IUploadFile
    {
    }


}
