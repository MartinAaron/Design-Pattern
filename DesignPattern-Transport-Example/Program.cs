using System;
using DesignPattern_Example.Implement;

namespace DesignPattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //fix transport
            Transport ts = new Car();
            ts.ShowEngine();
            ts.DriveTransport();
        }
    }
}