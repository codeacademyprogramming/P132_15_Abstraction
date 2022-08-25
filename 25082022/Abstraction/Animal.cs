using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal abstract class Animal
    {
        public string Name;
        public byte Age;
        public abstract void MakeSound();
    }
}
