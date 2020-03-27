using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ManagerClass;
using EmployeeModel;

namespace EmpManagment.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly IManager manager;

        public EmployeeController(IManager manager)
        {
            this.manager = manager;
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
    }

}
