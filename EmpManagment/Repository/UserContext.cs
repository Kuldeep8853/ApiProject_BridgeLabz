// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserContext.cs" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// ----------------------------------------------------------------------------------------------------------------------
using Microsoft.EntityFrameworkCore;
using Model;

namespace Repository
{
    /// <summary>
    /// UserContext Class.
    /// </summary>
    public class UserContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserContext"/> class.
        /// </summary>
        /// <param name="options">options.</param>
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets Employee DBSet.
        /// </summary>
        public DbSet<Employee> Employees { get; set; }
    }
}
