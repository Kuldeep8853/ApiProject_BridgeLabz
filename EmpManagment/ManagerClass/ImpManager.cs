﻿using EmployeeModel;
using Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagerClass
{
    public class ImpManager : IManager
    {
        public readonly IEmployee Employee;

        public ImpManager(IEmployee employee)
        {
            this.Employee = employee;
        }

       /* public IEnumerable<Employee> GetAll()
        {
            return null;
        }

        public Employee Get(long id)
        {
            return null;
        }*/

        public Task<int> Add(Employee entity)
        {
            return Employee.Add(entity);
        }

       /* public void Update(Employee employee, Employee entity)
        {
           
        }

        public void Delete(Employee employee)
        {
           
        }

        IEnumerable<Employee> IManager.GetAll()
        {
            throw new NotImplementedException();
        }*/
    }
}
