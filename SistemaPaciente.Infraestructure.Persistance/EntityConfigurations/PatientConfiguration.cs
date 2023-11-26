﻿using SistemaPaciente.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaPaciente.Infraestructure.Persistence.EntityConfigurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patient");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Identification).IsUnique();
            builder.Property(x => x.LastModifiedBy).IsRequired(false);
            builder.Property(x => x.CreatyBy).IsRequired(false);
            builder.Property(x => x.ImageUrl).IsRequired(false);
        }
    }
}
