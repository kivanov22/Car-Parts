using AutoMapper;
using Car_Parts_API.Infrastructure.Data.Models;
using CarParts.API.Core.ViewModels;

namespace CarParts.API.Core.AutoMapperProfile
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Part, PartDto>();
            CreateMap<PartDto, Part>();
            CreateMap<IEnumerable<PartDto>, Part>();
            CreateMap<IEnumerable<Part>, PartDto>();
            CreateMap<List<Part>, PartDto>();
            CreateMap<List<Part>, PartDto>();
        }
    }
}
