using EmployeeModel;
using Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagerClass
{
    public class EmployeeManager : IEmployeeManager
    {
        public readonly IEmployeeRepository Employee;

        public EmployeeManager(IEmployeeRepository employee)
        {
            this.Employee = employee;
        }

        public IEnumerable<Employee> GetAll()
        {
            return Employee.GetAll();
        }

        public Employee Get(long id)
        {
            return Employee.Get(id);
        }

        public Task<int> Add(Employee entity)
        {
            return Employee.Add(entity);
        }

        public void Update(Employee employee, Employee entity)
        {
            Employee.Update(employee, entity);
        }

        public void Delete(Employee employee)
        {
            Employee.Delete(employee);
        }

    }
}
