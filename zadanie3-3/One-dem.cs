using System;

namespace Gleb
{

    public interface IUnoDem : IBaseArray
    {
        void DeleteDuplicates();
    }

    public sealed class OneDem : BaseClass, IUnoDem
    {
        private int[] array;

        public OneDem()
        {
            Console.WriteLine("OneDemensional   ");
            CreateMas();
        } 

        public override void MidVal()
        {
            int allsum = 0;
            foreach (var item in array)
            {
                allsum += Convert.ToInt32(item);
            }
            Console.WriteLine($"Mid value: {allsum/array.Length}");
        }

        public override void Print()
        {
            Print_in(array);
        }
        
        protected override void Input()
        {
            Console.WriteLine("Length of your array:");
            int len = int.Parse(Console.ReadLine());
            array = new int[len];
            for(int i = 0; i < len; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        protected override void Random()
        {
            Random rand = new Random();
            int len = rand.Next(2,10);
            array = new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = rand.Next(-200, 200);
            }
        }

        public void DeleteDuplicates()
        {
            int n = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                for (int it = 0; it < array.Length; it++)
                {
                    if (array[i] == array[it] && it != i && it > i)
                    {
                        n--;
                    }
                }
            }
            int[] newArray = new int[n];
            int newIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isDuplicate = false;
                for (int it = 0; it < i; it++)
                {
                    if (array[i] == array[it])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }
            array = newArray;
        }

        private static void Print_in(int[] array)
        {   
            for (int h = 0; h < array.Length; h++)
            {
                Console.Write($"{array[h]} ");
            }
            Console.WriteLine();
        }
    }
}