using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManagerClass
{
    public interface IEmployeeManager
    {
       /* IEnumerable<Employee> GetAll();
        Employee Get(long id);*/
        Task<int> Add(Employee employee);
       /* void Update(Employee employee, Employee entity);
        void Delete(Employee employee);
*/
    }
}
