using _2024_airbnb_herkansing.Models;

namespace _2024_airbnb_herkansing.Repositories
{
    public interface IReservationRepository
    {
        public Task<IEnumerable<Reservation>> GetAllLandlordsAsync(CancellationToken cancellationToken);
        public Task<Reservation> GetReservationByIdAsync(int id, CancellationToken cancellationToken);

        public Task<Reservation> SetReservationRequestAsync(Reservation reservation, CancellationToken cancellationToken);
    }
}
