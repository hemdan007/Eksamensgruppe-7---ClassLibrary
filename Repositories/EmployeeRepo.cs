using Eksamensprojekt___Gruppe_7.Models;
//by Ahmed

namespace Eksamensprojekt___Gruppe_7.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {

        //static list of employees
        private static List<Employee> _employees = new List<Employee>();

        //static variable to assign a new unique ID
        private static int nextId = 1;


        //static variable to check if the list is initialized
        private static bool initialized = false;

        // Constructor - initializes with default employees if not already initialized
        public EmployeeRepo()
        {
           if (!initialized)
            {                 
                _employees.Add(new Employee { Id = nextId++, Name = "Mads", Picture = "Mads.png", PhoneNumber ="12121250", Email ="ml@ri.dk", JobTitle = "Ansvarlig"});
                _employees.Add(new Employee { Id = nextId++, Name = "Maja",  Picture = "Maja.png", PhoneNumber = "12121259", Email = "me@ri.dk", JobTitle = "Dyrepasser" });
                _employees.Add(new Employee { Id = nextId++, Name = "Claus", Picture = "Claus.png", PhoneNumber = "40608023", Email = "------", JobTitle = "Frivillig" });
                initialized = true;
            }
        }




        //returns the list of employees
        public List<Employee> GetAll()
        {
            return new List<Employee>(_employees);
        }

        //returns an employee by ID
        public Employee GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        //adds an employee to the list and assigns a new unique ID
        public void Add(Employee employee)
        {
            employee.Id = nextId++;
            _employees.Add(employee);
        }

        //updates an employee in the list
        public void Update(Employee employee)
        {
            //find the index of the employee with the same ID
            int index = _employees.FindIndex(e => e.Id == employee.Id);

            //if not found, throw exception
            if (index == -1)
            {
                //using a specific exception type (KeyNotFoundException) to clearly indicate that the employee wasnt found
                throw new KeyNotFoundException("Medarbejder findes ikke!");
            }

            //replace the old employee data with the new one
            _employees[index] = employee;
        }
        //deletes an employee from the list by ID if found
        public void Delete(int id)
        {
            Employee employee= GetById(id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }
}

