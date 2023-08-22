using AutoMapper;
using Car_Parts_API.Infrastructure.Data.Models;
using CarParts.API.Core.Auth;
using CarParts.API.Core.ViewModels.Parts;
using CarParts.API.Infrastructure.Data.Auth;

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
            CreateMap<PartDto, Part>();

            CreateMap<RegisterRequest, User>();
            CreateMap<User, RegisterRequest>()
                .ReverseMap();

            // User -> AuthenticateResponse
            //CreateMap<User, AuthenticateResponse>();

            // RegisterRequest -> User
            //CreateMap<RegisterRequest, User>();

            // UpdateRequest -> User
            CreateMap<UpdateRequest, User>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
                ));

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

            CreateMap<IEnumerable<AllPartsDto>, Part>();
            CreateMap<IEnumerable<Part>, AllPartsDto>();
            CreateMap<List<Part>, AllPartsDto>()
                .ReverseMap();
            CreateMap<List<Part>, AllPartsDto>();
        }
    }
}
