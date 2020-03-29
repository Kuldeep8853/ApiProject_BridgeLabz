// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeManager.cs" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// ----------------------------------------------------------------------------------------------------------------------

namespace ManagerClass
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EmployeeModel;
    using Repository;

    /// <summary>
    /// EmployeeManager class, Its interface between Web api project and Repository project.
    /// </summary>
    public class EmployeeManager : IEmployeeManager
    {
        /// <summary>
        /// Declare Instance valiable.
        /// </summary>
        private readonly IEmployeeRepository employee;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeManager"/> class.
        /// </summary>
        /// <param name="employee">employee.</param>
        public EmployeeManager(IEmployeeRepository employee)
        {
            this.employee = employee;
        }

        /// <summary>
        /// Get all employee.
        /// </summary>
        /// <returns>All Employee.</returns>
        public IEnumerable<Employee> GetAll()
        {
            return this.employee.GetAll();
        }

        /// <summary>
        /// Get one by one Employee within EmployeeId.
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>Employee.</returns>
        public Employee Get(long id)
        {
            return this.employee.Get(id);
        }

        /// <summary>
        /// Post->Api/Employee.
        /// </summary>
        /// <param name="employee">entity.</param>
        /// <returns>Task. <int>.</returns>
        public Task<int> Add(Employee employee)
        {
            return this.employee.Add(employee);
        }

        /// <summary>
        /// Put->Api/Employee.
        /// </summary>
        /// <param name="employee">employee.</param>
        /// <param name="entity">entity.</param>
        public void Update(Employee employee, Employee entity)
        {
            this.employee.Update(employee, entity);
        }

        /// <summary>
        /// Delete->Api/Employee.
        /// </summary>
        /// <param name="employee">employee.</param>
        public void Delete(Employee employee)
        {
            this.employee.Delete(employee);
        }
    }
}
