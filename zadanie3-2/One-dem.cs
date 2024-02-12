using System;

namespace Gleb
{
    public sealed class OneDem:BaseClass
    {
        public bool autofill = false;
        private int[] array;
        private int[] prom;

        public OneDem(bool autofill)
        {
            Console.WriteLine("OneDemensional");
            CreateMas();
        }

        public override void CreateMas()
        {
            Console.WriteLine("Creating array...");
            Console.WriteLine("Length of your array:");
            int new_length = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you want to turn on autofill?(True or False)");
            bool auto  = bool.Parse(Console.ReadLine());
            if(auto)
            {
                Random num = new Random();
                array = Random(num.Next(-200, 200));
            }
            else
            {
                array = Input(new_length);
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

        private int[] Input(int len)
        {
            prom = new int[len];
            for(int i = 0; i < len; i++)
                {
                    prom[i] = int.Parse(Console.ReadLine());
                }
            return prom;
        }

        private int[] Random(int len)
        {
            prom = new int[len];
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                array[i] = rand.Next(-200, 200);
            }
            return prom;
        }
    }
}