using SistemaPaciente.Core.Application.ViewModels.UserViewModels;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Interfaces.Repositories
{
    public interface IUserRepository:IGenericRepositoryAsync<User>
    {
        bool ValidateUserName(string userName);
        bool ValidateEmail(string email);
        Task<User> LoginAsync(LoginViewModel loginView);
    }
}
