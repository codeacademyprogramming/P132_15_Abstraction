using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    internal class Human
    {
        public string Name;
        public string Surname;

        public virtual void Introduce()
        {
            Console.WriteLine($"FullName: {Name} {Surname}");
        }

        public void ShowFullName()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
    }
}
