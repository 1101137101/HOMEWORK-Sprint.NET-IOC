
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao
    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employees1 = new Employee();
            employees1.Id = "Piglet";
            employees1.Name = "小豬";
            employees1.Age = 22;
            employees.Add(employees1);

            Employee employees2 = new Employee();
            employees2.Id = "Ming";
            employees2.Name = "許家銘";
            employees2.Age = 21;
            employees.Add(employees2);

            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employees = new Employee();
            employees.Id = "Ming";
            employees.Name = "許家銘";
            employees.Age = 21;

            return employees;
        }

    }
}
