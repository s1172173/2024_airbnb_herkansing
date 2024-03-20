using _2024_airbnb_herkansing.DTOs;
using _2024_airbnb_herkansing.Models;
using AutoMapper;

namespace _2024_airbnb_herkansing
{
    public class MapperProfile : Profile
    {
         public MapperProfile()
        {
            CreateMap<Location, LocationDTO>();
        }
    }
}
