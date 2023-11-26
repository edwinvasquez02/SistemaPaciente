﻿using AutoMapper;
using SistemaPaciente.Core.Application.ViewModels.AppoinmentStatusViewModels;
using SistemaPaciente.Core.Application.ViewModels.RolViewModels;
using SistemaPaciente.Core.Application.ViewModels.AppoinmentStatusViewModels;
using SistemaPaciente.Core.Application.ViewModels.DoctorViewModels;
using SistemaPaciente.Core.Application.ViewModels.LabResultViewModels;
using SistemaPaciente.Core.Application.ViewModels.LabTestViewModels;
using SistemaPaciente.Core.Application.ViewModels.MedicalViewModels;
using SistemaPaciente.Core.Application.ViewModels.PatientViewModels;
using SistemaPaciente.Core.Application.ViewModels.RolViewModels;
using SistemaPaciente.Core.Application.ViewModels.UserViewModels;
using SistemaPaciente.Core.Domain.Entities;

namespace SistemaPaciente.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region Users
            CreateMap<User, UserViewModel>().ForMember(x => x.RolName, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Creaty, opt => opt.Ignore())
                .ForMember(x => x.CreatyBy, opt => opt.Ignore());

            CreateMap<User, SaveUserViewModel>()
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Creaty, opt => opt.Ignore())
                .ForMember(x => x.CreatyBy, opt => opt.Ignore());
            #endregion

            #region Rols
            CreateMap<Rol, RolViewModel>()
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Creaty, opt => opt.Ignore())
                .ForMember(x => x.CreatyBy, opt => opt.Ignore());

            CreateMap<Rol, SaveRolViewModel>()
               .ReverseMap()
               .ForMember(x => x.LastModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
               .ForMember(x => x.Creaty, opt => opt.Ignore())
               .ForMember(x => x.CreatyBy, opt => opt.Ignore());
            #endregion

            #region Patients
            CreateMap<Patient, PatientViewModel>()
                .ForMember(dest => dest.DateOfBorn, opt => opt.MapFrom(src => src.DateOfBorn.ToString("yyyy-MM-dd")))
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Creaty, opt => opt.Ignore())
                .ForMember(x => x.CreatyBy, opt => opt.Ignore());



            CreateMap<Patient, SavePatientViewModel>()
                .ForMember(x => x.File, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Creaty, opt => opt.Ignore())
                .ForMember(x => x.CreatyBy, opt => opt.Ignore());
            #endregion

            #region Doctors
            CreateMap<Doctor, SaveDoctorViewModel>()
                .ForMember(x => x.File, opt => opt.Ignore())
                .ReverseMap()
                 .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Creaty, opt => opt.Ignore())
                .ForMember(x => x.CreatyBy, opt => opt.Ignore());

            CreateMap<Doctor, DoctorViewModel>()
               .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
               .ForMember(x => x.Creaty, opt => opt.Ignore())
               .ForMember(x => x.CreatyBy, opt => opt.Ignore());

            #endregion

            #region LabTests
            CreateMap<LabTests, LabTestViewModel>()
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Creaty, opt => opt.Ignore())
                .ForMember(x => x.CreatyBy, opt => opt.Ignore());

            CreateMap<LabTests, SaveLabTestViewModel>()
               .ReverseMap()
               .ForMember(x => x.LastModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
               .ForMember(x => x.Creaty, opt => opt.Ignore())
               .ForMember(x => x.CreatyBy, opt => opt.Ignore());
            #endregion

            #region AppoinmetStatus
            CreateMap<AppoinmentStatus, SaveAppoinmentViewModel>()
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
               .ForMember(x => x.Creaty, opt => opt.Ignore())
               .ForMember(x => x.CreatyBy, opt => opt.Ignore());

            CreateMap<AppoinmentStatus, AppoinmentStatusViewModel>()
               .ReverseMap()
               .ForMember(x => x.LastModified, opt => opt.Ignore())
              .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
              .ForMember(x => x.Creaty, opt => opt.Ignore())
              .ForMember(x => x.CreatyBy, opt => opt.Ignore());
            #endregion

            #region MedicalAppoinmets
            CreateMap<MedicalAppointment, MedicalViewModel>()
                .ForMember(x => x.PatientName, opt => opt.Ignore())
                .ForMember(x => x.DoctortName, opt => opt.Ignore())
                .ForMember(x => x.StatustName, opt => opt.Ignore())
               .ReverseMap()
               .ForMember(x => x.LastModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
               .ForMember(x => x.Creaty, opt => opt.Ignore())
               .ForMember(x => x.CreatyBy, opt => opt.Ignore());




            CreateMap<MedicalAppointment, SaveMedicalViewModel>()
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Creaty, opt => opt.Ignore())
                .ForMember(x => x.CreatyBy, opt => opt.Ignore());

            #endregion

            #region LabResult
            CreateMap<PatientLabTests, SaveLabResultViewModel>()
               .ReverseMap()
               .ForMember(x => x.LastModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
               .ForMember(x => x.Creaty, opt => opt.Ignore())
               .ForMember(x => x.CreatyBy, opt => opt.Ignore());




            CreateMap<MedicalAppointment, SaveMedicalViewModel>()
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Creaty, opt => opt.Ignore())
                .ForMember(x => x.CreatyBy, opt => opt.Ignore());
            #endregion
        }
    }
}