using System;
using OOPExercise;

namespace OOPexercise
{
    public class Car : IVehicle
    {
        public int Fuel {get; set; }
        public Car(int fuel)
        {
            Fuel = fuel;
        }
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Not Fuel");
            }
        }
        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
    }
}