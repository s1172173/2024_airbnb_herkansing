using _2024_airbnb_herkansing.DTOs;

namespace _2024_airbnb_herkansing.Services
{
    public interface IReservationService
    {
        public Task<ReservationReponseDTO> SetReservationResquestAsync(ReservationReponseDTO reservationReponse, CancellationToken cancellationToken);
    }
}
