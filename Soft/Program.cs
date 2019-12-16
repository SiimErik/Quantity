using Logic;
using System;

namespace Soft
{
    class Program
    {
        static void Main(string[] args)
        {
            var u = new BaseUnit();
            u.SystemOfUnits = new SystemOfUnits();
            u.SystemOfUnits.Name = "AS";
        }
    }
}
