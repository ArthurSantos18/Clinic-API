using AutoMapper;
using ClinicAPI.Models.Dto;
using ClinicAPI.Models.DTOs;
using ClinicAPI.Models.Entities;

namespace ClinicAPI.Profiles
{
    public class ClinicProfile : Profile
    {
        public ClinicProfile()
        {
            // Patient
            CreateMap<Patient, PatientDetailsDto>();
            CreateMap<Patient, PatientDto>();
            CreateMap<PatientAddDto, Patient>();
            CreateMap<PatientUpdateDto, Patient>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

            // Appointment
            CreateMap<Appointment, AppointmentDto>()
                .ForMember(dest => dest.Specialty, opt => opt.MapFrom(src => src.Specialty.Name))
                .ForMember(dest => dest.Professional, opt => opt.MapFrom(src => src.Professional.Name))
                .ForMember(dest => dest.Pacient, opt => opt.MapFrom(src => src.Patient.Name));
            
            CreateMap<Appointment, AppointmentDetailsDto>();
            CreateMap<AppointmentAddDto, Appointment>();
            CreateMap<AppointmentUpdateDto, Appointment>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

            // Professional
            CreateMap<Professional, ProfessionalDto>();
            CreateMap<Professional, ProfessionalDetailsDto>()
                .ForMember(dest => dest.Specialties, opt => opt.MapFrom(src => src.Specialties.Select(x => x.Name).ToArray()));
            CreateMap<ProfessionalAddDto, Professional>();
            CreateMap<ProfessionalUpdateDto, Professional>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

            // Specialty
            CreateMap<Specialty, SpecialtyDto>();
            CreateMap<Specialty, SpecialtyDetailsDto>()
                .ForMember(dest => dest.Professionals, opt => opt.MapFrom(src => src.Professionals.Select(x => x.Name).ToArray()));
            CreateMap<SpecialtyAddDto, Specialty>();
            CreateMap<SpecialtyUpdateDto, Specialty>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

            
        }
    }
}
