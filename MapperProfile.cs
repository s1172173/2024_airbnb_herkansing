using _2024_airbnb_herkansing.DTOs;
using _2024_airbnb_herkansing.Models;
using AutoMapper;

namespace _2024_airbnb_herkansing
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Location, GetDetailsDTO>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.SubTitle, opt => opt.MapFrom(src => src.SubTitle))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Rooms, opt => opt.MapFrom(src => src.Rooms))
                .ForMember(dest => dest.NumberOfGuests, opt => opt.MapFrom(src => src.NumberOfGuests))
                .ForMember(dest => dest.PricePerDay, opt => opt.MapFrom(src => src.PricePerDay))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Features, opt => opt.MapFrom(src => src.Features))
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
                .ForMember(dest => dest.Landlord, opt => opt.MapFrom(src => src.Landlord));

            CreateMap<Location, GetMaxPriceDTO>()
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.PricePerDay));

            CreateMap<Landlord, LandlordDTO>()
                 .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName))
                 .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.Avatar.Url));

            CreateMap<Location, LocationDTO>()
                .ForMember(dest => dest.LandlordAvatarURL, opt => opt.MapFrom(src => src.Landlord.Avatar.Url))
                .ForMember(dest => dest.ImageURL, opt => opt.MapFrom(src => src.Images.Select(i => i.Url)));

            CreateMap<Location, LocationDTOV2>()
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.PricePerDay))
                .ForMember(dest => dest.ImageURL, opt => opt.MapFrom(src => src.Images.Select(i => i.Url)))
                .ForMember(dest => dest.LandlordAvatarURL, opt => opt.MapFrom(src => src.Landlord.Avatar.Url));

            CreateMap<Location, LocationSearchDTO>();

            CreateMap<Reservation, ReservationReponseDTO>()
                .ForMember(dest => dest.LocationName, opt => opt.MapFrom(src => src.Location.Title))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.FirstName + " " + src.Customer.LastName))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Location.PricePerDay * (src.EndDate.HasValue && src.StartDate.HasValue ? (src.EndDate.Value.Date - src.StartDate.Value.Date).TotalDays : 0)))
                .ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src.Discount));

            CreateMap<ReservationRequestDTO, Reservation>()
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                .ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src.Discount))
                .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => new Customer { Email = src.Email, FirstName = src.FirstName, LastName = src.LastName }));
        }
    }
}