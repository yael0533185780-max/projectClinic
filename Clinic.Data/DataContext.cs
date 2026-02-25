
using Clinic.Core.Entities;
using Microsoft.EntityFrameworkCore;
//using projectClinic;

namespace Clinic.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Clients> clients { get; set; }

        public DbSet<Doctors> doctors { get; set; }

        public DbSet<Queues> queues { get; set; }
        public DbSet<User> user { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Clinic");
        }
    }   
}
