using System;
using SingleResponsibility.Funcs;

namespace SingleResponsibility
{
    public class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void GetName()
        {
            Console.WriteLine($"My Name is {Name}");
        }

        public PrintNameTable PrintNameTable => new PrintNameTable();
    }
}