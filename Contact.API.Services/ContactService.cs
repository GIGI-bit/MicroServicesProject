using Contact.API.Infrastructure;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Services
{
    public class ContactService:IContactService
    {
        private List<ContactModel> AllContacts { get; set; }
        public ContactService()
        {
            
        }

        public void Add(API.Models.ContactModel model)
        {
            model.Id = new Random().Next(1, 10000);
            AllContacts.Add(model);
        }

        public void Delete(int id)
        {
            //var item = AllContacts.Remove();
        }

        public List<API.Models.ContactModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public API.Models.ContactModel GetContactById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, API.Models.ContactModel model)
        {
            throw new NotImplementedException();
        }
    }
}
