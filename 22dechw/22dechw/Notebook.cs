using System;
using System.Collections.Generic;
using System.Text;

namespace _22dechw
{
    internal class Notebook:Product
    {
        public Notebook(string name, int price, int ram):base(name,price)
        {
            Ram= ram;
        }
        public int Ram;
        
        public string GetInfo()
        {
            return $"Name:{Name}" +
                $"Price:{Price}" +
                $"Ram:{Ram}";
        }
    }

}
