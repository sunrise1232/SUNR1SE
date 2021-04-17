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
    }
}
