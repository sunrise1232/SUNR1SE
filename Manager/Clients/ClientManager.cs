using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage;
using WebApplication1.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Managers.Clients
{
    public class ClientManager: IClientManager
    {
        private TourContext _ContextClient;

        /* public Client()
          {
              _ContextClient = new PeopleContext();
          }
        */

        public ClientManager(TourContext context)
        {
            _ContextClient = context;
        }

       
        public void AddClient(Client client)
        {
            _ContextClient.clients.Add(client);
        }

        public ICollection<Client> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
