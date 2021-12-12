using Contact.API.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Service
{
    public class ContactService : IContactService
    {
        public Models.Contact GetContact()
        {
            return new Models.Contact()
            {
                Id = Guid.NewGuid(),
                FirstName = "Cüneyt",
                LastName = "ERASLAN"
            };
        }

        public Models.Contact GetContactById(Guid Id)
        {
            return new Models.Contact()
            {
                Id = Id,
                FirstName = "Cüneyt",
                LastName = "ERASLAN"
            };
        }
    }
}
