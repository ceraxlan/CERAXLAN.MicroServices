using Contact.API.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public Models.Contact Get()
        {
            return _contactService.GetContact();
        }

        [HttpGet("{id}")]
        public Models.Contact GetContactById(Guid Id)
        {
            return _contactService.GetContactById(Id);
        }
    }
}
