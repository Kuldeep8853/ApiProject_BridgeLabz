using Microsoft.EntityFrameworkCore;

namespace EmpManagment.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }
    }
}
