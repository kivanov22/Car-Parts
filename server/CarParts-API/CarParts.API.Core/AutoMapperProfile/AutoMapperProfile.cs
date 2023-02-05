using AutoMapper;
using Car_Parts_API.Infrastructure.Data.Models;
using CarParts.API.Core.ViewModels;

namespace CarParts.API.Core.AutoMapperProfile
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Part, PartDto>()
                .ReverseMap()
                //opt => opt.MapFrom(src => src.PartTypes.PartTypeName))
                //.ForMember(dest => dest.PartTypes.Description,
                //opt => opt.MapFrom(src => src.PartTypes.Description))
            ;
            CreateMap<PartDto, Part>()
                
            //.ForMember(dest => dest.PartTypes.PartTypeName,
            //    opt => opt.MapFrom(src => src.PartTypes.PartTypeName))
            //    .ForMember(dest => dest.PartTypes.Description,
            //    opt => opt.MapFrom(src => src.PartTypes.Description))
            ;
            CreateMap<IEnumerable<PartDto>, Part>();
            CreateMap<IEnumerable<Part>, PartDto>();
            CreateMap<List<Part>, PartDto>()
                .ReverseMap();
            CreateMap<List<Part>, PartDto>();
        }
    }
}
