﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPaciente.Core.Domain.Common
{
    public class AuditableBaseEntity
    {
        public int Id { get; set; }
        public string? CreatyBy { get; set; }
        public DateTime Creaty { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime LastModified { get; set; }
    }
}
