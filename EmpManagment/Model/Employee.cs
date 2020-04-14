// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Employee.cs" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// ----------------------------------------------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// This is Model class of the Employee Managment Project.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets declare Instance valiable EmployeeId as a Primary Key of the Employee Table.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets declare Instance valiable FirstName of the Employee Table.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets declare Instance valiable LastName of the Employee Table.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets declare Instance valiable PhoneNumber of the Employee Table.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets declare Instance valiable Email of the Employee Table.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets declare Instance valiable Password of the Employee Table.
        /// </summary>
        public string Password { get; set; }
    }
}
