using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Abstract_Factory
{
    internal abstract class Sofa
    {
        public abstract string Seats();
        public void Show(string data)
        {
            Console.WriteLine(data);
           
        }
    }
}
