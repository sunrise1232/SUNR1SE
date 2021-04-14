using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Storage.Entity
{
    public class Tour
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

    }
}
