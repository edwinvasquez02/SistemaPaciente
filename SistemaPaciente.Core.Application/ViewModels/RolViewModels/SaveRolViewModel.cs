﻿using SistemaPaciente.Core.Application.Validations;
using System.ComponentModel.DataAnnotations;

namespace SistemaPaciente.Core.Application.ViewModels.RolViewModels
{
    public class SaveRolViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "ESTE CAMPO ES OBLIGATORIO")]
        [RolValidations]
        public string Name { get; set; } = null!;
    }
}
