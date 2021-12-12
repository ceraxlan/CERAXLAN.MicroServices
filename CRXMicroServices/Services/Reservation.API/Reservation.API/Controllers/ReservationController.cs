using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        public Models.Reservation Get()
        {
            return _reservationService.GetReservation();
        }


        [HttpGet("{Id}")]
        public Models.Reservation GetResById(Guid Id)
        {
            return _reservationService.GetReservationById(Id);
        }
    }
}
