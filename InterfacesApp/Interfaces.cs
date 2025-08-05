// See https://aka.ms/new-console-template for more information
using System;

namespace InterfacesApp
{
    // Define interface
    interface IMovable
    {
        void Move();
    }

    // Implement interface in Car
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Implement interface in Bicycle
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
        }
    }
}

