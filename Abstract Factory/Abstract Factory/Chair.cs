using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Abstract_Factory
{
    internal abstract class Chair
    {
        public abstract string Legs();
        public void Show(string data)
        {
            Console.WriteLine(data);
        }
    }
}
