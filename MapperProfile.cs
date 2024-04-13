using _2024_airbnb_herkansing.DTOs;
using _2024_airbnb_herkansing.DTOs.v2;
using _2024_airbnb_herkansing.Models;
using AutoMapper;

namespace _2024_airbnb_herkansing
{
    public class MapperProfile : Profile
    {
         public MapperProfile()
        {

            CreateMap<Location, LocationDTO>()
            .ForMember(dest => dest.LandlordAvatarURL, opt => opt.MapFrom(src => src.Landlord.Avatar.Url))
            .ForMember(dest => dest.ImageURL, opt => opt.MapFrom(src => src.Image.Url));

            CreateMap<Location, LocationDTOV2>()
                .ForMember(member => member.Price, options => options.MapFrom(property => property.PricePerDay))
                .ForMember(member => member.ImageURL, options => options.MapFrom(property => property.Image.Url))
                .ForMember(member => member.LandlordAvatarURL, options => options.MapFrom(property => property.Landlord.Avatar.Url));
/*
            CreateMap<Location, LocationDTO>();
            CreateMap<Location, LocationDTOV2>();*/
        }
    }
}
