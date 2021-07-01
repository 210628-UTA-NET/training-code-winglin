using System;

namespace HelloWorld
{
    public class Serialization
    {
        private const string _filePath = "./StoreFile/House.json";
        public static void SerializationMain()
        {
            House house1 = new House()
            {
                Name = "Wing",
                Price = 500
            }
        }
    }
}