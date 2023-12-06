using Microsoft.EntityFrameworkCore;

namespace backend_development_for_dotnet.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Customer> Customers {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=CodeFirstDB;user=root;password=password");
        }
    }
}