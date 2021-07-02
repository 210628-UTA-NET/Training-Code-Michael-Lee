using System; //Importing the system namspace 
using HouseFunction;
using HelloWorld;

/*
using PascalCase for most of the naming
using camelCase for naming fields
*/

namespace HelloWorld
{
    class Program
    {
        private static string _first = "Hello";
        private static string _last = "World";

        /*
        The main method is the first method that will be running 
        when using the command dotnet run. 
        Static: I have not instantiated the program class to use that method
        void method will not return anything
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            test obj = new test();

            Console.WriteLine(obj.SomeMethod());
            Console.WriteLine(_first + _last);

            //House Example
            House objHouse = new House();
            Console.WriteLine(objHouse.getColor());
            objHouse.setColor("Blue");
            Console.WriteLine(objHouse.Price);
            objHouse.Name = "Michael Lee's House";
            Console.WriteLine(objHouse.Name);
        }
    }
    class test
    {
        public string SomeMethod()
        {
            //Console.WriteLine("Some method was called");
            return "Hello World Sommethod";
        }
    }
}