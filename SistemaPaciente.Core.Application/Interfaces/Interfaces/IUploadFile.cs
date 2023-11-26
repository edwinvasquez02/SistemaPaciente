using Microsoft.AspNetCore.Http;

namespace SistemaPaciente.Core.Application.Interfaces.Interfaces
{
    public interface IUploadFile
    {
        string UplpadFile(IFormFile file, int id, bool isEditMode = false, string imagePath = "");
    }
}
