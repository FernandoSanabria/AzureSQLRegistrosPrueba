using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ApiAzureSQLRegistrosPrueba.Models;

namespace ApiAzureSQLRegistrosPrueba.Controllers
{  
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController: Controller
    {
        private ContactsContext contactsContext;

        public ContactController(ContactsContext context)
        {
            contactsContext = context;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Contacts>> Get()
        {
            return contactsContext.ContactSet.ToList();
        }

        ~ContactController() 
        {
            contactsContext.Dispose();
        }

    }
}