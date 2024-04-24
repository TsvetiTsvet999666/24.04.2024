using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FirstTask
{
    public class Persons
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public double Salary { get; private set; }

        public Persons(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public void IncreaseSalary(double bonus)
        {
            if (bonus < 0)
            {
                throw new ArgumentException("Bonus must be non-negative.");
            }
            if (Age < 30)
            {
                Salary += bonus / 2;
            }
            else
            {
                Salary += bonus;
            }
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Salary: {Salary:F2}";
        }

    }
}
