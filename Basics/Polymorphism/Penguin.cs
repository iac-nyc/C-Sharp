using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Penguin : Bird
    {
        public override  void Move()
        {
            Console.WriteLine("Penguins Waddle");
        }
    }
}
