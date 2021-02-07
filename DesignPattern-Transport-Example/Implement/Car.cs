using System.Collections.Generic;

namespace DesignPattern_Example.Implement
{
    public class Car : Transport
    {
        protected override IEngine CarEngine => new EightXEngine();

        protected override List<IDriver> GetDrivers()
        {
            return new List<IDriver>()
            {
                new RobotDriver()
            };
        }
    }
}