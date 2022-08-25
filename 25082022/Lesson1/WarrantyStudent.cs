using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    internal class WarrantyStudent:Student
    {
        public string PrevGroupNo;
        public override void Introduce()
        {
            Console.WriteLine($"Name: {Name} - GroupNo: {GroupNo} - {PrevGroupNo}");
        }
    }
}
