using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ManagerClass;
using EmployeeModel;
using System.Collections.Generic;

namespace EmpManagment.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly IEmployeeManager manager;

        public EmployeeController(IEmployeeManager manager)
        {
            this.manager = manager;
        }

        // GET: api/Employee
        [Route("GetAllEmployee")]
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = manager.GetAll();
            return Ok(employees);
        }

        // GET: api/Employee/5
        [Route("GetEmployee")]
        [HttpGet]
        public async Task<IActionResult> Get(long id)
        {
            Employee employee = this.manager.Get(id);

            if (employee == null)
            {
                return this.NotFound("The Employee record couldn't be found.");
            }

            return this.Ok(employee);
        }

        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            var result = await this.manager.Add(employee);
            if (result == 1)
                return this.Ok(employee);
            else
                return this.BadRequest();
        }

        // PUT: api/Employee/5
        [Route("UpdateEmployee")]
        [HttpPut]
        public IActionResult Put(long id, [FromBody] Employee employee)
        {
            if (employee == null)
            {
                return this.BadRequest("Employee is null.");
            }

            Employee employeeToUpdate = manager.Get(id);
            if (employeeToUpdate == null)
            {
                return this.NotFound("The Employee record couldn't be found.");
            }

            manager.Update(employeeToUpdate, employee);
            return this.NoContent();
        }

        // DELETE: api/Employee/5
        [Route("DeleteEmployee")]
        [HttpDelete]
        public IActionResult Delete(long id)
        {
            Employee employee = this.manager.Get(id);
            if (employee == null)
            {
                return this.NotFound("The Employee record couldn't be found.");
            }

            manager.Delete(employee);
            return this.NoContent();
        }
    }

}
