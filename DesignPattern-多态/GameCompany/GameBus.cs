using System.Collections.Generic;

namespace DesignPattern.GameCompany
{
    public class GameBus : Company
    {
        public override List<Employee> GetImployee()
        {
            return new List<Employee>()
            {
                new Tester(), new GameDeveloper()
            };
        }

        public override void CreateSoftWare()
        {
            var employees = GetImployee();
            employees.ForEach(emp =>
            {
                emp.DoWork();                
            });
        }
    }
}