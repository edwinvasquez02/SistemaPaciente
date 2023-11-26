using AutoMapper;
using SistemaPaciente.Core.Application.Interfaces.Repositories;
using SistemaPaciente.Core.Application.Interfaces.Services;
using SistemaPaciente.Core.Application.ViewModels.LabTestViewModels;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Services
{
    public class LabTestServices : GenericService<SaveLabTestViewModel, LabTestViewModel, LabTests>, ILabTestServices
    {
        public LabTestServices(IMapper mapper, ILabTestRepository _labTestRepository) : base(mapper, _labTestRepository)
        {
        }
    }
}