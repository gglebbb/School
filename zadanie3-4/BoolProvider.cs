using System;

namespace Gleb
{    
    class BoolProvider : IProvider<bool>
    {
        private static Random random = new Random();

        public bool GetRandomValue()
        {
            return random.Next(0, 2) > 0;
        }

        public bool GetUserValue()
        {
            return bool.Parse(Console.ReadLine());
        }
    }
}