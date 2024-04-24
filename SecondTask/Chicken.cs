using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Chicken
    {
        private string name;
        private int age;
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value.Trim();
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentException("Age should be between 0 and 15");
                }

                age = value;
            }
        }
        public Chicken(string name, int age)
        {
            Name = name; 
            Age = age; 
        }
    }
}
