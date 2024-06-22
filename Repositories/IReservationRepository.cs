using _2024_airbnb_herkansing.Models;
using _2024_airbnb_herkansing.Models.DTOs;

namespace _2024_airbnb_herkansing.Repositories
{
    public interface IReservationRepository
    {
        public Task<IEnumerable<Reservation>> GetAllReservationsAsync(CancellationToken cancellationToken);
        public Task<Reservation> GetReservationByIdAsync(int id, CancellationToken cancellationToken);

        public Task<Reservation> MakeReservationAsync(ReservationRequestDTO reservationRequest, CancellationToken cancellationToken);
        public Task<UnAvailableDatesDTO> GetUnavailableDatesAsync(int locationId, CancellationToken cancellationToken);
    }
}
