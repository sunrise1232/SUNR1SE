using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Managers.Clients
{
    interface IClient
    {
        ICollection<Client> GetAll();

        void AddClient(string name, string midlename, string lastname, string phonenumber,string login,string password);
        void AuthorizationClient(string login, string password);
    }
}
