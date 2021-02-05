using System;
using System.Runtime.CompilerServices;
using DesignPattern.GameCompany;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Company game = new GameBus();
            game.CreateSoftWare();
        }
    }
}
