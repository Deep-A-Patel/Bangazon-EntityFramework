using Bangazon.Models;
using Microsoft.EntityFrameworkCore;

namespace Bangazon.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}