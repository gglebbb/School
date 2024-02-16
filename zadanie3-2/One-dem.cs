using System;

namespace Gleb
{
    public sealed class OneDem:BaseClass
    {
        public bool autofill = false;
        private int[] array;

        public OneDem(bool autofill)
        {
            Console.WriteLine("OneDemensional   ");
            CreateMas(autofill);
        }

        public override void CreateMas(bool auto)
        {
            Console.WriteLine("Creating array...");
            if(auto)
            {
                Random();
            }
            else
            {
                Input();
            }
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
        
        private static bool Exists(int value, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        private static void Print_in(int[] array)
        {   
            for (int h = 0; h < array.Length; h++)
            {
                Console.Write($"{array[h]} ");
            }
            Console.WriteLine();
        }

        private void Input()
        {
            Console.WriteLine("Length of your array:");
            int len = int.Parse(Console.ReadLine());
            array = new int[len];
            for(int i = 0; i < len; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        private void Random()
        {
            Random rand = new Random();
            int len = rand.Next(2,10);
            array = new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = rand.Next(-200, 200);
            }
        }
    }
}