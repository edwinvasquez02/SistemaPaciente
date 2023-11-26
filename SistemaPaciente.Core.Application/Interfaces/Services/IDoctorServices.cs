using SistemaPaciente.Core.Application.Interfaces.Interfaces;
using SistemaPaciente.Core.Application.ViewModels.DoctorViewModels;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Interfaces.Services
{
    public interface IDoctorServices:IGenericService<SaveDoctorViewModel,DoctorViewModel,Doctor>,IUploadFile
    {
    }
}
