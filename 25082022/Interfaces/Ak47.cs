using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    internal class Ak47 : IGun,IFireable
    {
        private int _magazineCapacity;
        public int MagazineCapacity
        {
            get => _magazineCapacity;
            set
            {
                if (value > 0)
                    _magazineCapacity = value;
            }
        }
        public int CurrentMagazine { get ; set ; }

        public void Fire()
        {
            CurrentMagazine-=2;
        }

        public void ReloadMagazine()
        {
            CurrentMagazine = _magazineCapacity;
        }
    }
}
