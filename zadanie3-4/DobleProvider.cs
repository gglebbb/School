using System;

namespace Gleb
{
    class DoubleProvider : IProvider<double>
    {
        private static Random random = new Random();

        public double GetRandomValue()
        {
            return random.Next(0, 101);
        }

        public double GetUserValue()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}