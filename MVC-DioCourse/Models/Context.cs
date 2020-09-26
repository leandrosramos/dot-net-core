using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_DioCourse.Models
{
    public class Context : DbContext
    { 
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            //Configuring the connection string for Sql Server. 
            //@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True"
            optionsBuilder.UseSqlServer(@"Server=ARSESP_089;Database=MVC_DioCourse;Integrated Security=True");
        }
    }
}
