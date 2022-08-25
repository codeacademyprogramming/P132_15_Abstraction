using System;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat mestan = new Cat();
            mestan.MakeSound();

            Dog artur = new Dog();
            artur.MakeSound();

            Car car = new Car();
            car.Drive(40);


            ElectroCar electroCar = new ElectroCar();
            electroCar.Drive(20);
        }
    }
}
