// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployeeManager.cs" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// ----------------------------------------------------------------------------------------------------------------------

namespace ManagerClass
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EmployeeModel;

    /// <summary>
    /// Declare Interface in Manager class.
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// Get All employee.
        /// </summary>
        /// <returns>All Employee.</returns>
        IEnumerable<Employee> GetAll();

        /// <summary>
        /// Get Employee by EmployeeiD.
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>Employee.</returns>
        Employee Get(long id);

        /// <summary>
        /// Declare Post method in Api/Employee.
        /// </summary>
        /// <param name="employee">employee.</param>
        /// <returns>Task.<int>.</returns>
        Task<int> Add(Employee employee);

        /// <summary>
        /// Declare Put methos in Api/Employee.
        /// </summary>
        /// <param name="employee">employee.</param>
        /// <param name="entity">entity.</param>
        void Update(Employee employee, Employee entity);

        /// <summary>
        /// Declare Delete methos in Api/Employee.
        /// </summary>
        /// <param name="employee">employee.</param>
        void Delete(Employee employee);
    }
}
