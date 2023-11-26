using AutoMapper;
using SistemaPaciente.Core.Application.Interfaces.Repositories;
using SistemaPaciente.Core.Application.Interfaces.Services;
using SistemaPaciente.Core.Application.ViewModels.AppoinmentStatusViewModels;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Services
{
    public class AppoinmentStatusService : GenericService<SaveAppoinmentViewModel, AppoinmentStatusViewModel, AppoinmentStatus>,IAppoinmetStatusService
    {
        private readonly IAppoinmentStatusRepository _appoinmentStatusRepository;
        public AppoinmentStatusService(IMapper mapper, IAppoinmentStatusRepository appoinmentStatusRepository) : base(mapper, appoinmentStatusRepository)
        {
            _appoinmentStatusRepository = appoinmentStatusRepository;
        }

        public async Task<int> GetAppoinmetIdbyName(string name)
        {
            var id = await _appoinmentStatusRepository.GetAppoinmetIdbyName(name);
            return id;
        }
    }
}
