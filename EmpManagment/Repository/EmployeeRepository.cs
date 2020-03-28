using EmployeeModel;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly UserContext _employeeContext;

        public EmployeeRepository(UserContext context)
        {
            _employeeContext = context;

        }

       /* public IEnumerable<Employee> GetAll()
        {
            return _employeeContext.Employees.ToList();
        }

        public Employee Get(long id)
        {
            return _employeeContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
        }*/

        public Task<int> Add(Employee employee)
        {
            _employeeContext.Employees.Add(employee);
            var result = _employeeContext.SaveChangesAsync();
            return result;
        }

       /* public void Update(Employee employee, Employee entity)
        {
            employee.FirstName = entity.FirstName;
            employee.LastName = entity.LastName;
            employee.Email = entity.Email;
            employee.DateOfBirth = entity.DateOfBirth;
            employee.PhoneNumber = entity.PhoneNumber;

            _employeeContext.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            _employeeContext.Employees.Remove(employee);
            _employeeContext.SaveChanges();
        }*/
    }
}
