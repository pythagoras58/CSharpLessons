using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Circle
    {
        // variables
        double radius;
        double pi = 3.14;

        public void AcceptRadius()
        {
            radius = 4.5;
        }

        public double GetArea()
        {
            return pi * radius * radius;
        }

        public void showResults()
        {
            Console.WriteLine("Radius: {0}", radius);
            Console.WriteLine("Areaa: {1}", GetArea());
        }
    }
}
