using SistemaPaciente.Core.Domain.Common;

namespace SistemaPaciente.Core.Domain.Entities
{
    public class LabTests:AuditableBaseEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<PatientLabTests> PatientLabTests { get; set; } = null!;

    }
}
