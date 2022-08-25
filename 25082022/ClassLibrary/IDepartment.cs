using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public interface IDepartment
    {
        Employee[] Employees { get; }
        void AddEmployee(Employee emp);

        Employee[] GetEmployeesBySalary(double min, double max);
    }
}
