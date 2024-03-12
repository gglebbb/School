using System;

namespace Gleb
{

    public sealed class DuoDem<T> : BaseClass, IArray<T>
    {
        private T[,] duo_arr;
        private IProvider<T> _fill;

        public DuoDem(IProvider<T> fill)
        {
            Console.WriteLine("Length of your new duo_arr: ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Wigth of your new duo_arr: ");
            int w = int.Parse(Console.ReadLine());

            duo_arr = new T[l,w];
            _fill = fill;
            CreateMas();
        }

        public override void Print()
        {
            Console.WriteLine($"\n{typeof(T)} dos array:");
            Console.WriteLine("Your duo_arr:");
            for(int i = 0; i < duo_arr.GetLength(0); i++)
            {
                for(int j = 0; j < duo_arr.GetLength(1); j++)
                {
                    Console.Write(duo_arr[i,j]+" ");
                }
                Console.Write("\n");
            }
        }
   
        protected override void Input()
        {
            for (int i = 0; i < duo_arr.GetLength(0); i++)
            {
                for (int j = 0; j < duo_arr.GetLength(1); j++)
                {
                    duo_arr[i, j] = _fill.GetUserValue();
                }
                Console.WriteLine();
            }
        }

        protected override void Random()
        {
            Random rand = new Random();
            for (int i = 0; i < duo_arr.GetLength(0); i++)
            {
                for (int j = 0; j < duo_arr.GetLength(1); j++)
                {
                    duo_arr[i, j] = _fill.GetRandomValue();
                }
                Console.WriteLine();
            }
        }
    }

}
