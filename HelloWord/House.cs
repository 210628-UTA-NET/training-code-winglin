using System;

namespace HouseFunction
{
    public class House
    {
        private string _color;

        //auto generate constructor by typing 'ctor'
        public House()
        {
            Console.WriteLine("House constructor was used");
            _color = "Red";
        }
    }
}