﻿using _2024_airbnb_herkansing.Models;
using _2024_airbnb_herkansing.Repositories;
using AutoMapper;
using _2024_airbnb_herkansing.Models.DTOs;

namespace _2024_airbnb_herkansing.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public ReservationService(IReservationRepository reservationRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReservationReponseDTO>> GetAllReservationsAsync(CancellationToken cancellationToken)
        {
            var reservations = await _reservationRepository.GetAllReservationsAsync(cancellationToken);
            return _mapper.Map<IEnumerable<ReservationReponseDTO>>(reservations);
        }

        public async Task<ReservationReponseDTO> GetReservationByIdAsync(int id, CancellationToken cancellationToken)
        {
            var reservation = await _reservationRepository.GetReservationByIdAsync(id, cancellationToken);
            return _mapper.Map<ReservationReponseDTO>(reservation);
        }

        public async Task<ReservationReponseDTO> MakeReservationAsync(ReservationRequestDTO reservationRequest, CancellationToken cancellationToken)
        {
            // Check for availability
            var unavailableDates = await _reservationRepository.GetUnavailableDatesAsync(reservationRequest.LocationId, cancellationToken);
            if (unavailableDates.UnAvailableDates.Any(d => d >= reservationRequest.StartDate && d <= reservationRequest.EndDate))
            {
                return null; 
            }

            var createdReservation = await _reservationRepository.MakeReservationAsync(reservationRequest, cancellationToken);
            return _mapper.Map<ReservationReponseDTO>(createdReservation);
        }
    }
}
