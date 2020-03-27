using EmployeeModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IEmployee
    {
        // IEnumerable<Employee> GetAll();
        //Employee Get(long id);
         Task<int> Add(Employee entity);
        /* void Update(Employee dbEntity, Employee entity);
         void Delete(Employee entity);*/
    }

}
