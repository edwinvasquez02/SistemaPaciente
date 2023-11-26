using SistemaPaciente.Core.Application.ViewModels.UserViewModels;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Interfaces.Services
{
    public interface IUserServices:IGenericService<SaveUserViewModel,UserViewModel,User>
    {
        Task<List<UserViewModel>> GetAllViewModelWithInclude();
        Task<UserViewModel> LoginAsync(LoginViewModel loginView);

        Task<bool> ChangePassword(ChangePasswordViewModel vm);



    }
}
