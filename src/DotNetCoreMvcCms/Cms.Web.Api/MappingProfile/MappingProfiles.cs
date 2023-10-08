using AutoMapper;
using Cms.Data.Models.Entities;
using Cms.Web.Api.DTO;

namespace Cms.Web.Api.MappingProfile
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<DoctorCreateDto, DoctorEntity>().ReverseMap();
            CreateMap<DoctorUpdateDto, DoctorEntity>().ReverseMap();
            CreateMap<AdminUpdateDto, AdminEntity>().ReverseMap();
            CreateMap<AdminCreateDto, AdminEntity>().ReverseMap();
            CreateMap<PatientCreateDto, PatientEntity>().ReverseMap();
            CreateMap<PatientUpdateDto, PatientEntity>().ReverseMap();
        }
    }
}
