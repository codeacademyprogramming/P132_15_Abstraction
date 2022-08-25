using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    internal interface IGun
    {
        int MagazineCapacity { get; set; }
        int CurrentMagazine { get; set; }

        void ReloadMagazine();


    }
}
