using System;

namespace MyApplication
{
    class Person
    {
        public string Name    // property
        { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }
}