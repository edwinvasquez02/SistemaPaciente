using System.ComponentModel.DataAnnotations;

namespace SistemaPaciente.Core.Application.ViewModels.LabResultViewModels
{
    public class UpdateLabResultViewModel
    {
        public int Id { get; set; }
        public int IdPatient { get; set; }
        public int IdLabTests { get; set; }
        public bool IsCompleted { get; set; }
        [Required(ErrorMessage = "ESTE CAMPO ES OBLIGATORIO")]
        public string? Comments { get; set; }
    }
}
