using Microsoft.EntityFrameworkCore;

namespace EmployeeModel
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True");
        }
    }
}
