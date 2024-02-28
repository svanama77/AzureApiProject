using AzureApiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AzureApiProject.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmployeeEntity> employees { get; set; }
    }
}
