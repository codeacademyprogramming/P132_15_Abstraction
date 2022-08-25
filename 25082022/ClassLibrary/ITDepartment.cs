using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ITDepartment : IDepartment
    {

        public ITDepartment(int limit)
        {
            _employeeLimit = limit;
        }
        private Employee[] _employees = new Employee[0];
        public Employee[] Employees { get=> _employees; }

        private int _employeeLimit;

        public int EmployeeLimit
        {
            get => _employeeLimit;
            set
            {
                if (_employees.Length <= value)
                    _employeeLimit = value;
            }
        }

        private double _salaryLimit;

        public double SalaryLimit
        {
            get => _salaryLimit;
            set
            {
                if (value >= _calcTotalSalary())
                    _salaryLimit = value;
            }
        }



        public void AddEmployee(Employee emp)
        {
            if (_employees.Length < _employeeLimit && CheckNewEmpSalary(emp.Salary))
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = emp;
            }
           
        }

        private double _calcTotalSalary()
        {
            double totalSalary = 0;

            for (int i = 0; i < _employees.Length; i++)
            {
                totalSalary += _employees[i].Salary;
            }

            return totalSalary;
        }

        public bool CheckNewEmpSalary(double salary)
        {
            return _calcTotalSalary() + salary <= _salaryLimit;
        }

        public Employee[] GetEmployeesBySalary(double min, double max)
        {
            Employee[] employees = new Employee[0];

            for (int i = 0; i < _employees.Length; i++)
            {
                if(_employees[i].Salary>=min && _employees[i].Salary<=max)
                {
                    Array.Resize(ref employees, employees.Length + 1);
                    employees[employees.Length - 1] = _employees[i];
                }
            }

            return employees;
        }
    }
}
