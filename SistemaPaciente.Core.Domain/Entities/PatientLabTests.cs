using SistemaPaciente.Core.Domain.Common;

namespace SistemaPaciente.Core.Domain.Entities;

public class PatientLabTests : AuditableBaseEntity
{
    public int IdPatient { get; set; }
    public Patient Patient { get; set; } = null!;
    public int IdLabTests { get; set; }
    public LabTests LabTests { get; set; } = null!;
    public string? Comments { get; set; } 
    public bool IsCompleted { get; set; }
    public int IdMedicalAppoinment { get; set; }
    public MedicalAppointment MedicalAppointment { get; set; } = null!;
}
