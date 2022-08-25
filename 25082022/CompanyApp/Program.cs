using System;
using ClassLibrary;

namespace CompanyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITDepartment ItDep = new ITDepartment(2);
            ItDep.SalaryLimit = 1000;


            string opt;
            do
            {
                Console.WriteLine("1. Isci elave et "+(ItDep.EmployeeLimit==ItDep.Employees.Length?"(limit dolub)":""));
                Console.WriteLine("2. Iscilere bax");
                Console.WriteLine("3. Iscileri maaslarina gore axtar");
                Console.WriteLine("0. Cix");


                Console.WriteLine("\nSecim edin:");
                opt = Console.ReadLine();


                switch (opt)
                {
                    case "1":
                        AddEmployee(ItDep);
                        break;
                    case "2":
                        for (int i = 0; i <ItDep.Employees.Length; i++)
                        {
                            Console.WriteLine(ItDep.Employees[i].GetInfo());
                        }
                        break;
                    case "3":
                        Console.WriteLine("min: ");
                        string minStr = Console.ReadLine();
                        double min = Convert.ToDouble(minStr);

                        Console.WriteLine("max: ");
                        string maxStr = Console.ReadLine();
                        double max = Convert.ToDouble(maxStr);

                        var wantedEmps = ItDep.GetEmployeesBySalary(min, max);
                        for (int i = 0; i < wantedEmps.Length; i++)
                        {
                            Console.WriteLine(wantedEmps[i].GetInfo());
                        }

                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Yanlis secim etdiniz!");
                        break;
                }



            } while (opt!="0");
        }

        static void AddEmployee(ITDepartment dep)
        {
            if (dep.EmployeeLimit == dep.Employees.Length)
            {
                Console.WriteLine("Isci limiti doludur!");
                return;
            }

            Console.Write("Fullname: ");
            string fullname = Console.ReadLine();

            Console.Write("Position: ");
            string position = Console.ReadLine();


            double salary;
            bool checkSalaryGreaterThanMinSalary = true;
            bool checkDepSalaryLimit = true;
            do
            {
                if (!checkSalaryGreaterThanMinSalary)
                    Console.WriteLine("Salary 250-den az ola bilmez!");
                else if (!checkDepSalaryLimit)
                    Console.WriteLine("Istici elave edile bilinmez, maas limiti dasir!");



                Console.Write("Salary: ");
                string salaryStr = Console.ReadLine();
                salary = Convert.ToDouble(salaryStr);

                if (salary < 250)
                    checkSalaryGreaterThanMinSalary = false;
                else checkSalaryGreaterThanMinSalary = true;

                if (!dep.CheckNewEmpSalary(salary))
                    checkDepSalaryLimit = false;
                else checkDepSalaryLimit = true;

            } while (!checkSalaryGreaterThanMinSalary || !checkDepSalaryLimit);


            Employee employee = new Employee
            {
                FullName = fullname,
                Position = position,
                Salary = salary
            };

            dep.AddEmployee(employee);
        }


      
    }
}
