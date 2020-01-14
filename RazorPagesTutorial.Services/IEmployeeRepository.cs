using RazorPagesTutorial.models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RazorPagesTutorial.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int Id);
    }
}
