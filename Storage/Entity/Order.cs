using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Storage.Entity
{
    public class Order
    {
        public int Id { get; set; }

        public int TourId { get; set; }
        public Tour Tour { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        public string AcceptDate { get; set; }


    }
}
