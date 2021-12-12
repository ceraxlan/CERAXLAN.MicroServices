using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Infrastructure
{
    public interface IReservationService
    {
         void Create(Models.Reservation Reservation);
         Models.Reservation GetReservation();
         Models.Reservation GetReservationById(Guid Id);
    }
}
