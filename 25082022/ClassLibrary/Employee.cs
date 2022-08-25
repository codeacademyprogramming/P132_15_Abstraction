using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public  class Employee
    {
        public string FullName;
        public string Position;

        private double _salary = 250;
        public double Salary
        {
            get=> _salary;
            set
            {
                if (value >= 250)
                    _salary = value;
            }
        }

        public string GetInfo()
        {
            return $"Fullname: {FullName} - Position: {Position} - Salary: {Salary}";
        }
    }
}
