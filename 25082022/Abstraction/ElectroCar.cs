using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class ElectroCar:Vehicle
    {
        public double CurrentBattery;
        public double BatteryForKm;

        public override void Drive(double km)
        {
            double needBattery = km * BatteryForKm;

            if (CurrentBattery >= needBattery)
            {
                CurrentBattery -= needBattery;
                Millage += km;
            }
        }

    }
}
