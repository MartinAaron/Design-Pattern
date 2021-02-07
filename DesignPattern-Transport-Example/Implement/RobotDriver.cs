using System;

namespace DesignPattern_Example.Implement
{
    public class RobotDriver : IDriver
    {
        public void Drive()
        {
            Console.WriteLine("Auto Drive");
        }
    }
}