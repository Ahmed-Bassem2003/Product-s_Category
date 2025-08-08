using ITI_Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ITI_Final_Project.Context
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = "server =DESKTOP-NJN8LNS; database = ITI_final_Project; Trusted_Connection = true;MultipleActiveResultSets = true;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionstring);
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

    }
}
