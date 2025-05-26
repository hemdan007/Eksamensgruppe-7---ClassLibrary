using Eksamensgruppe_7___ClassLibrary.Models;
using Eksamensgruppe_7___ClassLibrary.Repositories;
namespace Eksamensgruppe_7___ClassLibrary.Service
// by Ahmed

{
    public class EmployeeService
    {

        // Instance of the service used to perform employee operations 
        private readonly EmployeeRepo _repo = new EmployeeRepo();

        //get alla employees
        public List<Employee> GetAll() 
        {
            return _repo.GetAll();
        }

        //get a single employee by ID
        public Employee GetById(int id) 
        {
            return _repo.GetById(id);
        }

        //add a new employee
        public void Add(Employee employee) 
        {
            _repo.Add(employee);
        }

        //edit an employee
        public void Update(Employee employee)
        {
            _repo.Update(employee);
        }

        //delete an employee
        public void Delete(int id) 
        {
            _repo.Delete(id);
        }

    }
}
