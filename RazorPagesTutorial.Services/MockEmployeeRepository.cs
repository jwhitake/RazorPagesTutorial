using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RazorPagesTutorial.models;

namespace RazorPagesTutorial.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "Mary@john.com", PhotoPath = "mary.png"},
                new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "John@john.com", PhotoPath = "john.png"},
                new Employee() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "Sam@john.com", PhotoPath = "sam.png"},
                new Employee() { Id = 4, Name = "David", Department = Dept.HR, Email = "David@john.com", PhotoPath = "david.png"},
                new Employee() { Id = 5, Name = "Sue", Department = Dept.PayRoll, Email = "Sue@john.com", PhotoPath = "sue.png"},
                new Employee() { Id = 6, Name = "Ignacious", Department = Dept.PayRoll, Email = "Ignacious@john.com"},
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;

        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
