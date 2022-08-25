using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Bycle:Vehicle
    {
        public override void Drive(double km)
        {
            Millage += km;
        }
    }
}
