using System;
using HouseFunction;

/*
    Naming conventions in C#
    - PascalCase for most naming convetion
    - camelCase for naming fields
*/

namespace HelloWord
{
    class Program
    {
        // we can use underscores for private fields to reference them easier in our code
        private static string _first = "Hello";
        private static string _last = "World!";

        /*
            -Main is the first method that will be called/run whenever you use the command 'dotnet run'
            - static means that i don't have to instantiate the Program class before using that method
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Something");
            
            Test obj = new Test(); //Will instantiate the Test class
            obj.SomeMethod();//Method was called because the class was instantiated

            Console.WriteLine(_first + " " + _last);
            Console.WriteLine(obj.SomeMethod());

            // Console.WriteLine(args[0] + args[1]);

            //House Example
            House objHouse = new House();
            Console.WriteLine(objHouse.getColor());
            objHouse.setColor("Blue");
            Console.WriteLine(objHouse.getColor());
            objHouse.Price = 8000;
            Console.WriteLine(objHouse.Price);
            objHouse.Name = "Stephen's House";
            Console.WriteLine(objHouse.Name);
        }
    }

    class Test
    {
        public string SomeMethod()
        {
            //return keyword will tell that to return the follow implemtation
            return "Hello World SomeMethod";
        }
    }
}

class Test
{
    public static void SomeMethod()
    {
        Console.WriteLine("SomeMethod was called");
    }
}