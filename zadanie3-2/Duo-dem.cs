using System;

namespace Gleb
{
    public sealed class DuoDem : BaseClass
    {
        public bool autofill = false;
        private int[,] duo_arr;
        private int[,] prom;

        public DuoDem( bool autofill)
        {
            Console.WriteLine("Information about duo demension array");
            Console.WriteLine("Length of array: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Wigth of array: ");
            int wigth = int.Parse(Console.ReadLine());
            duo_arr = new int[length, wigth];
            if(autofill)
            {
                duo_arr = Random(length, wigth);
            }
            else
            {
                duo_arr = Input(length, wigth);
            }
        }

        public override void CreateMas()
        {
            Console.WriteLine("Creating array...");
            Console.WriteLine("Sixe of your array(length and wigth)");
            string[] arr_inf = Console.ReadLine().Split(" ");
            Console.WriteLine("Do you want to turn on autofill?(True or False");
            bool auto  = bool.Parse(Console.ReadLine());
            if(auto)
            {
                Random l = new Random();
                int prom_length = l.Next(2,10);
                int prom_width = l.Next(2,10);
                duo_arr = Random(prom_length, prom_width);
            }
            else
            {
                
                Console.WriteLine("Length of your new array: ");
                int length = int.Parse(Console.ReadLine());
                Console.WriteLine("Wigth of your new array: ");
                int wigth = int.Parse(Console.ReadLine());
                duo_arr = Input(length, wigth);
            }    
        }

        public override void Print()
        {
            Console.WriteLine(duo_arr.Rank);
            Console.WriteLine("Your array:");
            for(int i = 0; i < duo_arr.GetLength(0); i++)
            {
                for(int j = 0; j < duo_arr.GetLength(1); j++)
                {
                    Console.Write(duo_arr[i,j]+" ");
                }
                Console.Write("\n");
            }
        }
        
        public override void MidVal()
        {
            int allsum = 0;
            int MidVal = 0;
            for(int i = 0; i < duo_arr.GetLength(0); i++)
            {
                for(int j = 0; j < duo_arr.GetLength(1); j++)
                {
                    allsum = allsum + duo_arr[i,j];
                }
            }
            MidVal = allsum/duo_arr.GetLength(0)/duo_arr.GetLength(1);
            Console.WriteLine($"Mid value: {MidVal}");
        }   
    
        private int[,] Input(int l, int w)
        {
            prom = new int[l, w];
            for(int i = 0; i < l; i++)
            {
                Console.WriteLine($"{i+1}-ая строка:");
                string[] str = Console.ReadLine().Split(' ');
                for(int j = 0; j<str.Length; j++)
                {
                    prom[i,j] = int.Parse(str[j]);
                }
            }
            return prom;
        }

        private int[,] Random(int l, int w)
        {
            prom = new int[l, w];
            Random rand = new Random();
            for (int i = 0; i < l; i++)
            {
                for(int j = 0; j<w; j++)
                {
                    prom[i,j] = rand.Next(-200, 200);
                }
            }
            return prom;
        }

    }
}