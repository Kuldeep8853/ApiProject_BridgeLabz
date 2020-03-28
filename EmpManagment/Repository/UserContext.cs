using EmployeeModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
        public class UserContext : DbContext
        {
            public UserContext(DbContextOptions<UserContext> options) : base(options)
            {

            }
            public DbSet<Employee> Employees { get; set; }
        }
}
