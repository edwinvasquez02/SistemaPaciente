﻿using SistemaPaciente.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPaciente.Core.Domain.Entities
{
    public class AppoinmentStatus: AuditableBaseEntity
    {
        public string Description { get; set; } = null!;

        public ICollection<MedicalAppointment> MedicalAppointments { get; set; } = null!;
    }
}
