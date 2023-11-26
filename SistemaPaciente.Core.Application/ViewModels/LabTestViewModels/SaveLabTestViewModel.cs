using System.ComponentModel.DataAnnotations;

namespace SistemaPaciente.Core.Application.ViewModels.LabTestViewModels
{
    public class SaveLabTestViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "ESTE CAMPO ES OBLIGATORIO")]
        public string Name { get; set; } = null!;
    }
}
