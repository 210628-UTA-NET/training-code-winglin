using System;
using System.Collections.Generic;
using System.Collections;

namespace HelloWorld {
    public class Collection {
        static List<string> strings = new List<string>();
        static ArrayList arrays = new ArrayList();

        public static void CollectionMain() {
            Console.WriteLine("===Collection Demo===");
            Console.WriteLine("=List Demo=");

            // adding string elements to strings list
            strings.Add("First element");
            strings.Add("Second element");
            strings.Add("Third element");
            
            Console.WriteLine("iterating thru list using foreach");
            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("iterating thru list using for");
            for (int i = 0; i < strings.Count; i+=2){
                Console.WriteLine("Current index is: " + i);
                Console.WriteLine(strings[i]);
            }

            Console.WriteLine("iterating thru list using while");
            int x = 0;
            while (x < strings.Count){
                Console.WriteLine(strings[x]);
                x += 1;
            }

            Console.WriteLine("=ArrayList Demo=");
            arrays.Add("first");
            arrays.Add(2);
            arrays.Add(true);

            foreach (var item in arrays)
            {
                Console.WriteLine(item);
            }

        }
    }
}