using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; //New Namespace 


namespace ConsoleEF.Models
{
    internal class ProdContext : DbContext //Database connection
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb; Database=Prods; Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBatch> ProductBatchs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}
