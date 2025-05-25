using Eksamensprojekt___Gruppe_7.Models;
using System.Collections.Generic;
//by Ahmed

namespace Eksamensprojekt___Gruppe_7.Repositories
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
