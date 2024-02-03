using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // ToStrign() = converts and object to its strign representation so that it is suitable for display

            Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car);

            Console.ReadKey();
        }
    }

    class Car
    {
        string make;
        string model;
        int year;
        string color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
            string message = $"This car is a {make} {model}";
            return message;
        }

    }
}