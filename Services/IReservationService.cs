using _2024_airbnb_herkansing.Models.DTOs;

namespace _2024_airbnb_herkansing.Services
{
    public interface IReservationService
    {
       Task<IEnumerable<ReservationReponseDTO>> GetAllReservationsAsync(CancellationToken cancellationToken);
        Task<ReservationReponseDTO> GetReservationByIdAsync(int id, CancellationToken cancellationToken);
        Task<ReservationReponseDTO> MakeReservationAsync(ReservationRequestDTO reservationRequest, CancellationToken cancellationToken);

    }
 }

