﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public class Employee
    {
       [Key]
        public long EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
