// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeRepository.cs" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// ----------------------------------------------------------------------------------------------------------------------

namespace Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Model;

    /// <summary>
    /// Implement the interface of the Repository Project.
    /// </summary>
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly UserContext employeeContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeRepository"/> class.
        /// </summary>
        /// <param name="context">context.</param>
        public EmployeeRepository(UserContext context)
        {
            this.employeeContext = context;
        }

        /// <summary>
        /// GetAll-> Api/Employee.
        /// </summary>
        /// <returns>AllEmployee.</returns>
        public IEnumerable<Employee> GetAll()
        {
            return this.employeeContext.Employees.ToList();
        }

        /// <summary>
        /// Get->Api/Employee.
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>Employee.</returns>
        public Employee Get(long id)
        {
            return this.employeeContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
        }

        /// <summary>
        /// Post->Api/Employee.
        /// </summary>
        /// <param name="employee">employee.</param>
        /// <returns>Task.</returns>
        public Task<int> Add(Employee employee)
        {
            this.employeeContext.Employees.Add(employee);
            var result = this.employeeContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Put->Api/Employee.
        /// </summary>
        /// <param name="employee">employee.</param>
        /// <param name="entity">entity.</param>
        public void Update(Employee employee, Employee entity)
        {
            employee.FirstName = entity.FirstName;
            employee.LastName = entity.LastName;
            employee.PhoneNumber = entity.PhoneNumber;
            employee.Email = entity.Email;
            employee.Password = entity.Password;
            

            this.employeeContext.SaveChanges();
        }

        /// <summary>
        /// Delete->Api/Employee.
        /// </summary>
        /// <param name="employee">employee.</param>
        public void Delete(Employee employee)
        {
            this.employeeContext.Employees.Remove(employee);
            this.employeeContext.SaveChanges();
        }
    }
}

