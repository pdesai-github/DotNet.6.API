using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore
{
    internal class DataStoreContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Models.Student> Students { get; set; }
        public DbSet<Models.Marks> Marks { get; set; }

        public DataStoreContext() 
        {
            _connectionString = "Data Source=localhost;Initial Catalog=SampledataStore;Integrated Security=True;TrustServerCertificate=True";
        }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
