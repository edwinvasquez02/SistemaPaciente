using SistemaPaciente.Core.Domain.Common;

namespace SistemaPaciente.Core.Domain.Entities
{
    public class Rol:AuditableBaseEntity
    {
        public string Name { get; set; } = null!;

        public ICollection<User> Users { get; set; } = null!;
    }
}
