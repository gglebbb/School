using System;

namespace Gleb
{

    public sealed class OneDem<T> : BaseClass, IArray<T>
    {
        private T[] array;
        private IProvider<T> _fill;

        public OneDem(IProvider<T> fill)
        {
            Console.WriteLine("OneDemensional");
            int length = int.Parse(Console.ReadLine());
            array = new T[length];
            _fill = fill;
            CreateMas();
        } 

        public override void Print()
        {
            Console.WriteLine($"\n{typeof(T)} uno array:");
            for (int h = 0; h < array.Length; h++)
            {
                Console.Write($"{array[h]} ");
            }
            Console.WriteLine();
        }
        
        protected override void Input()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = _fill.GetUserValue();
            }
        }

        protected override void Random()
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = _fill.GetRandomValue();
            }
        }

    }
}