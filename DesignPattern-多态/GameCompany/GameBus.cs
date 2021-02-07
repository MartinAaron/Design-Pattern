using System.Collections.Generic;

namespace DesignPattern.GameCompany
{
    public class GameBus : Company
    {
        public override List<Employee> GetEmployee()
        {
            return new List<Employee>()
            {
                new Tester(), new GameDeveloper()
            };
        }

        public override void CreateSoftWare()
        {
            var employees = GetEmployee();
            employees.ForEach(emp =>
            {
                emp.DoWork();                
            });
        }
    }
} 