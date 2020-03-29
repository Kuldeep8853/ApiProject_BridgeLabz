// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeController.cs" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// ----------------------------------------------------------------------------------------------------------------------

namespace EmpManagment.Controllers
{
    using EmployeeModel;
    using ManagerClass;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// EmployeeController class.
    /// </summary>
    [Route("api/controller")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// Declare instance valiable IEmployeeManager type.
        /// </summary>
        private readonly IEmployeeManager manager;
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref = "EmployeeController"/> class.
        /// </summary>
        /// <param name="manager">manager.</param>
        public EmployeeController(IEmployeeManager manager, ILoggerFactory loggerFactory)
        {
            this.manager = manager;
            this.logger = loggerFactory.CreateLogger<EmployeeController>();
        }

        /// <summary>
        /// GET: api/Employee.
        /// </summary>
        /// <returns>IActionResult.</returns>
        [Route("GetAllEmployee")]
        [HttpGet]
        public IActionResult Get()
        {
            logger.LogInformation("Get All Employee details...");
            IEnumerable<Employee> employees = this.manager.GetAll();
            return this.Ok(employees);
        }

        /// <summary>
        /// GET: api/Employee/5.
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>async Task.<IActionResult></returns>
        [Route("GetEmployee")]
        [HttpGet]
        public async Task<IActionResult> Get(long id)
        {
            logger.LogInformation("Get Employee with respect to id.....");
            Employee employee = this.manager.Get(id);

            if (employee == null)
            {
                return this.NotFound("The Employee record couldn't be found.");
            }

            return this.Ok(employee);
        }

        /// <summary>
        /// Post: api/Employee.
        /// </summary>
        /// <param name="employee">employee.</param>
        /// <returns>Task.<IActionResult>.</returns>
        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            logger.LogInformation("Add new Employee details....");
            var result = await this.manager.Add(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        ///  PUT: api/Employee/5.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="employee">employee.</param>
        /// <returns>IActionResult. </returns>
        [Route("UpdateEmployee")]
        [HttpPut]
        public IActionResult Put(long id, [FromBody] Employee employee)
        {
            logger.LogInformation("Update Employee details.....");
            if (employee == null)
            {
                return this.BadRequest("Employee is null.");
            }

            Employee employeeToUpdate = this.manager.Get(id);
            if (employeeToUpdate == null)
            {
                return this.NotFound("The Employee record couldn't be found.");
            }

            this.manager.Update(employeeToUpdate, employee);
            return this.NoContent();
        }

        /// <summary>
        /// DELETE: api/Employee/5.
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>IActionResult.</returns>
        [Route("DeleteEmployee")]
        [HttpDelete]
        public IActionResult Delete(long id)
        {
            logger.LogInformation("Delete the Employee Details.....");
            Employee employee = this.manager.Get(id);
            if (employee == null)
            {
                return this.NotFound("The Employee record couldn't be found.");
            }

            this.manager.Delete(employee);
            return this.NoContent();
        }
    }
}
