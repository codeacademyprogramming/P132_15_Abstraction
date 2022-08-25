using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Car:Vehicle
    {
        public double CurrentFuel;
        public double FuelForKm;

        public override void Drive(double km)
        {
            double neededFuel = km * FuelForKm;
            if (CurrentFuel >= neededFuel)
            {
                CurrentFuel -= neededFuel;
                Millage += km;
            }
        }
    }
}
