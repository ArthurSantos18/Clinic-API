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
            CreateMap<Patient, PatientDetailsDto>();
            CreateMap<Patient, PatientDto>();
            CreateMap<PatientAddDto, Patient>();

            CreateMap<Appointment, AppointmentDto>()
                .ForMember(dest => dest.Specialty, opt => opt.MapFrom(src => src.Specialty.Name))
                .ForMember(dest => dest.Professional, opt => opt.MapFrom(src => src.Professional.Name));
        
        }
    }
}
