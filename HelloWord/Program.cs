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
            Console.WriteLine("Hello World!");
            Console.WriteLine(_first + _last);

            //House example
            House objHouse = new House();

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