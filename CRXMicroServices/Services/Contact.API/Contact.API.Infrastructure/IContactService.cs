using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Contact.API.Infrastructure
{
    public interface IContactService
    {
        Models.Contact GetContact();
        Models.Contact GetContactById(Guid Id);
    }
}
