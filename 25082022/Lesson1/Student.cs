using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    internal class Student:Human
    {
        public string GroupNo;

        public override void Introduce()
        {
            //base.Introduce();
            Console.WriteLine($"FullName: {Name} {Surname} \nGroupNo: {GroupNo}");
        }

    }
}
