using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    internal abstract class Gun
    {
        public abstract int MagazineCapacity { get; set; }
        public abstract int CurrentMagazine { get; set; }

        public abstract void ReloadMagazine();

    }
}
