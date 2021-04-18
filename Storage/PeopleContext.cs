using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Storage
{
    public class PeopleContext:DbContext
    {
        
            public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
            {

            }
       public DbSet<Client> clients { get; set; }
        public DbSet<Hotel> hotels { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Provider> providers { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Staff> staffs { get; set; }
        public DbSet<Tour> tours { get; set; }
        public DbSet<Town> towns { get; set; }
    }
}
