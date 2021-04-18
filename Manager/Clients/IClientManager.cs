using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage.Entity;
using WebApplication1.Storage;

namespace WebApplication1.Managers.Clients
{
    interface IClientManager
    {
        ICollection<Client> GetAll();

        void AddClient(Client Client);
        //void AuthorizationClient(string login, string password);
    }
}
