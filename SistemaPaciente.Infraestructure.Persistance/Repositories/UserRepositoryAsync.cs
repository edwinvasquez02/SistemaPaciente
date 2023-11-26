using SistemaPaciente.Core.Application.Helpers;
using SistemaPaciente.Core.Application.Interfaces.Repositories;
using SistemaPaciente.Core.Application.ViewModels.UserViewModels;
using SistemaPaciente.Core.Domain.Entities;
using SistemaPaciente.Infraestructure.Persistence.Context;

namespace SistemaPaciente.Infraestructure.Persistence.Repositories
{
    public class UserRepositoryAsync : GenericRepositoryAsync<User>, IUserRepository
    {
        private readonly ApplicationContext _dbContext;
        public UserRepositoryAsync(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public bool ValidateUserName(string userName)
        {
            var isCreated = _dbContext.Users.Any(x => x.UserName == userName);
            return isCreated;
        }

        public override async Task<User> AddAsync(User entity)
        {
            entity.Password = PassWordEncryption.ComputeSha256Hash(entity.Password);
            await base.AddAsync(entity);
            return entity;
        }

        public async Task<User> LoginAsync(LoginViewModel loginView)
        {
            string passwordEncrypy = PassWordEncryption.ComputeSha256Hash(loginView.Password);

            var users = await GetAllWithIncludeAsync(new List<string> { "Rol" });
            User user = users.FirstOrDefault(user => user.UserName ==loginView.UserName && user.Password == passwordEncrypy) ;

            return user;
        }

        public bool ValidateEmail(string email)
        {
            var isCreated = _dbContext.Users.Any(x => x.Email == email);
            return isCreated;
        }
    }
}
