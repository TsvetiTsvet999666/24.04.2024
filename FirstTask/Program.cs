using System.Collections.Generic;
using System;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Persons>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Persons(cmdArgs[0],
                
                int.Parse(cmdArgs[2]),
                double.Parse(cmdArgs[3]));
                persons.Add(person);
            }
            var bonus = double.Parse(Console.ReadLine());
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
