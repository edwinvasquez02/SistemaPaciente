﻿using SistemaPaciente.Core.Domain.Common;
using SistemaPaciente.Core.Domain.Entities;
using SistemaPaciente.Infraestructure.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace SistemaPaciente.Infraestructure.Persistence.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options) 
        {

        }
        public ApplicationContext()
        {
            
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Creaty = DateTime.Now;
                        entry.Entity.CreatyBy = "DefaultAppUser";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.LastModifiedBy = "DefaultAppUser";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RolConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new LabTestConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new PatientLabTestConfiguration());
            modelBuilder.ApplyConfiguration(new AppoinmentStatusConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalAppoinmentConfiguration());
        }

        //Dbsets.
        public DbSet<Rol> Rol { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<LabTests> LabTests { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientLabTests> PatientLabTests { get; set; }
        public DbSet<AppoinmentStatus> AppoinmentStatuses { get; set; }
        public DbSet<MedicalAppointment> MedicalAppoinments { get; set; }
    }
}
