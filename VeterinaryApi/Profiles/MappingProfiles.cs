using AutoMapper;
using Domain.Entities;
using VeterinaryApi.Dtos;

namespace VeterinaryApi.Profiles;

    public class MappingProfiles : Profile
    {
        public MappingProfiles(){
            CreateMap<Citation, CitationDto>().ReverseMap();
            CreateMap<Veterinarian, VeterinarianDto>().ReverseMap().ForMember(m => m.Citations, d => d.Ignore());
        }
    }
