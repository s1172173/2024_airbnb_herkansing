using AutoMapper;
using _2024_airbnb_herkansing.Models;
using _2024_airbnb_herkansing.Models.DTOs;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Location, GetDetailsDTO>();

        CreateMap<Location, GetMaxPriceDTO>()
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.PricePerDay));

        CreateMap<Landlord, LandlordDTO>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName))
            .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.Avatar.Url));

        CreateMap<Location, LocationDTO>()
            .ForMember(dest => dest.LandlordAvatarURL, opt => opt.MapFrom(src => src.Landlord.Avatar.Url))
            .ForMember(dest => dest.ImageURL, opt => opt.MapFrom(src => src.Images.Select(i => i.Url).ToList()));

        CreateMap<Location, LocationDTOV2>()
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.PricePerDay))
            .ForMember(dest => dest.ImageURL, opt => opt.MapFrom(src => src.Images.Select(i => i.Url).ToList()))
            .ForMember(dest => dest.LandlordAvatarURL, opt => opt.MapFrom(src => src.Landlord.Avatar.Url));

        CreateMap<Location, LocationSearchDTO>();

        CreateMap<ReservationRequestDTO, Reservation>()
            .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
            .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
            .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
            .ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src.Discount))
            .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => new Customer { Email = src.Email, FirstName = src.FirstName, LastName = src.LastName }));

        CreateMap<Reservation, ReservationReponseDTO>()
            .ForMember(dest => dest.LocationName, opt => opt.MapFrom(src => src.Location.Title))
            .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => $"{src.Customer.FirstName} {src.Customer.LastName}"))
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Location.PricePerDay * (src.EndDate ?? DateTime.MinValue).Subtract(src.StartDate ?? DateTime.MinValue).TotalDays))
            .ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src.Discount));
    }
}
