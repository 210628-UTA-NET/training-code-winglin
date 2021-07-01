using System;

namespace HelloWorld
{
    public class BoxingAndUnboxing
    {
        public static void BoxingAndUnboxingMain()
        {
            Console.WriteLine("===Boxing and Unboxing Demo===");

            int num = 123;
            // implicit conversion 
            double doubled = num;
            Console.WriteLine(doubled);

            int num1 = (int) doubled;
            System.Console.WriteLine(num1);

            //Boxing 
            //it is when a value type gets casted into an object
            //What happens is that the value is wrapped to give it a refeence
            object obj = num;
            System.Console.WriteLine(obj);

            //Unboxing
            // when you extract the value type from the object and just 
            //a syntax is needed (Cast)
            int num3 = (int)obj;
            System.Console.WriteLine(num3);
        }
    }
}