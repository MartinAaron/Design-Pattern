using System.Collections.Generic;

namespace DesignPattern
{
    public abstract class Company
    {
        public abstract List<Employee> GetEmployee();
        public abstract void CreateSoftWare();
    }
}