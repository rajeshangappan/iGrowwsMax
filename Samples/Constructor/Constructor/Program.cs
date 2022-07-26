using System;

namespace MyApplication
{
    public class Car
    {
        public string model;
        public string color;
        public int year;
        public Car()
        { 
            Console.WriteLine("Car sound is smooth");
        }
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;

        }

        class Program
        {
            static void Main(string[] args)
            {
                Car Ford = new Car("Mustang", "Red", 1969);
                Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
            }
        }
    }
}


