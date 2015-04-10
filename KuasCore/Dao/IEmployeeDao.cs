using KuasCore.Models;
using System;
using System.Collections.Generic;

namespace KuasCore.Dao
{
    public interface IEmployeeDao
    {

        IList<Employee> GetAllEmployees();

        Employee GetEmployeeById(string id);

    }

    public interface INewEmployeeDao
    {

        IList<Employee> GetAllEmployees();

        Employee GetEmployeeById(string id);

    }
}
