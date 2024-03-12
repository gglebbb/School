using System;

namespace Gleb
{
    public abstract class BaseClass : IBaseArray
    {
        protected abstract void Random();

        protected abstract void Input();

        public abstract void Print();

        public virtual void CreateMas()
        {
            Console.WriteLine($"Do you want to turn on random generation of arrays (yes or no)?");
            string s = Console.ReadLine().ToLower();
            if(s == "yes")
            {
                Random();
            }
            else
            {
                Input();
            }
        }

    }
}