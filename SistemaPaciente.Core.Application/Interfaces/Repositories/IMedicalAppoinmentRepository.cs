using SistemaPaciente.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPaciente.Core.Application.Interfaces.Repositories
{
    public interface IMedicalAppoinmentRepository:IGenericRepositoryAsync<MedicalAppointment>
    {
    }
}
