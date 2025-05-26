using Eksamensgruppe_7___ClassLibrary.Models;
using System.Collections.Generic;
//by Ahmed

namespace Eksamensgruppe_7___ClassLibrary.Repositories
{
    public interface IEmployeeRepo
    {
        //get all employees
        List<Employee> GetAll();

        //get an employee by ID
        Employee GetById(int id);

        //add a new employee
        void Add(Employee employee);

        //update existing employee
        void Update(Employee employee);

        //delete an employee by ID
        void Delete(int id);
    }
}
