using System;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();

            human1.Name = "Hikmet";
            human1.Surname = "Abbsov";

            human1.Introduce();

            Student student1 = new Student();
            student1.Name = "Abbas";
            student1.Surname = "Hikmetov";
            student1.GroupNo = "P123";

            student1.Introduce();

            WarrantyStudent warrantyStudent = new WarrantyStudent();
            warrantyStudent.Name = "Nermin";
            warrantyStudent.Surname = "Abbaszade";
            warrantyStudent.GroupNo = "P123";
            warrantyStudent.PrevGroupNo = "P122";

            warrantyStudent.Introduce();
        }
    }
}
