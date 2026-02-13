using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSolid.SOLID
{
    internal class Employee
    {
        public string Name { get; set; }

        private int _salary;

        public Employee(string name, int salary)
        {
            this.Name = name;   
            this._salary = salary;
        }

        public virtual int GetSalary()
        {
            return _salary;
        }
    }

    internal class Manager : Employee
    {
        public Manager(string name, int salary) : base(name, salary)
        {

        }

        public override int GetSalary()
        {
            // Managers get a 20% bonus
            return base.GetSalary() + (int)(base.GetSalary() * 0.2);
        }
    }

    internal class OpenClosedPrinciple
    {
        public void DisplaySalaries()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Alice", 50000),
                new Manager("Bob", 50000)
            };

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s Salary: {employee.GetSalary()}");
            }
        }
    }
}
