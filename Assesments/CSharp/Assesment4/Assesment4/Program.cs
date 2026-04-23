using System;
using NUnit.Framework;

namespace Assesment4
{
    public class Distance
    {
        public int kilometer;

        public static Distance AddDistance(Distance d1, Distance d2)
        {
            Distance d3 = new Distance();
            d3.kilometer = d1.kilometer + d2.kilometer;
            return d3;
        }

        public void Display()
        {
            Console.WriteLine("Total Distance: " + kilometer + " km");
        }
    }

    public class TestDistance
    {
        [Test]
        public static void Main()
        {
            Distance d1 = new Distance();
            Distance d2 = new Distance();

            d1.kilometer = 15;
            d2.kilometer = 25;

            Distance result = Distance.AddDistance(d1, d2);

            result.Display();
        }
    }
}