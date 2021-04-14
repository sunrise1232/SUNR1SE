using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Storage
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        { 
        }

        public DbSet<Student> Students { get ;set ;}

        public DbSet<Group> Groups { get ;set ;}
    }
}
