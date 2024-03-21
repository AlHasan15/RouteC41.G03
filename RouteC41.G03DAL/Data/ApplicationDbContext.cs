using Microsoft.EntityFrameworkCore;
using RouteC41.G03DAL.Data.Configrations;
using RouteC41.G03DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RouteC41.G03DAL.Data
{
    public class ApplicationDbContext : DbContext       
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseSqlServer("Server =.; Database = MVCApplicationG03; Trusted_connection =True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigurations() );
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }

        public DbSet<Department> Departments { get; set; }
    }
}
