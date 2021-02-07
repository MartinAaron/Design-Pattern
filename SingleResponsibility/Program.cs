using System;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Demo");
            
            e.PrintNameTable.Print(e.Name);
        }
    }
}