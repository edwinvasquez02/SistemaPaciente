using SistemaPaciente.Core.Application.Interfaces.Repositories;
using SistemaPaciente.Core.Domain.Entities;
using SistemaPaciente.Infraestructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using SistemaPaciente.Infraestructure.Persistence.Context;

namespace SistemaPaciente.Infraestructure.Persistence.Repositories
{
    public class AppoinmentStatusRepository : GenericRepositoryAsync<AppoinmentStatus>, IAppoinmentStatusRepository
    {
        private readonly ApplicationContext _dbcontext;
        public AppoinmentStatusRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task<int> GetAppoinmetIdbyName(string name)
        {
            var appoinmetId = await _dbcontext.AppoinmentStatuses
                .FirstOrDefaultAsync(x => x.Description == name);

            return appoinmetId.Id;
        }
    }
}
