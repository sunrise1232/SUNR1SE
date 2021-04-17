using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage;
using WebApplication1.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Managers.Clients
{
    public class Client: IClient
    {
        private PeopleContext _ContextClient;

        /* public Client()
          {
              _ContextClient = new PeopleContext();
          }
        */

        public Client(PeopleContext context)
        {
            _ContextClient = context;
        }

       
        public void AddClient(string name, string middlename, string lastname, string phonenumber, string login, string password)
        {
            var newClient = _ContextClient.Client.FirstOrDefault(st => st.Login != login);
             //if(login.Length<15 && login.Length > 6)
             //   if (password.Length < 15 && password.Length > 6)
                   _ContextClient.Clients.Add(newClient);
               
        }
        public void AuthorizationClient(string login, string password)
        {
            var oldClient = _ContextClient.Client.FirstOrDefault(st => st.Login == login);
            if(oldClient!=null)
            {
                if(oldClient.Password==password)
                {
                  
                }
            }
        }

        public ICollection<Client> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
