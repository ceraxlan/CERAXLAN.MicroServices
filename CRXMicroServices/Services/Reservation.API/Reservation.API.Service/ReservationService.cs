using Reservation.API.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Service
{
    public class ReservationService : IReservationService
    {
        public void Create(Models.Reservation Reservation)
        {
            
        }

        public Models.Reservation GetReservation()
        {
            return new Models.Reservation()
            {
                Id = Guid.NewGuid(),
                ResDate = DateTime.Now,
                CheckInDate = DateTime.Now.Date.AddDays(30),
                CheckOutDate = DateTime.Now.Date.AddDays(37),
                OwnerContact = Guid.NewGuid(),
                Amount = (new Random()).Next(1000, 10000)
            };
        }

        public Models.Reservation GetReservationById(Guid Id)
        {
            return new Models.Reservation()
            {
                Id = Id,
                ResDate = DateTime.Now,
                CheckInDate = DateTime.Now.Date.AddDays(30),
                CheckOutDate = DateTime.Now.Date.AddDays(37),
                OwnerContact = Guid.NewGuid(),
                Amount = (new Random()).Next(1000, 10000)
            };
        }
    }
}
