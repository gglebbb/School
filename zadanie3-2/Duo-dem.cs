using System;

namespace Gleb
{
    public sealed class DuoDem : BaseClass
    {
        public bool autofill = false;
        private int[,] duo_arr;

        public DuoDem( bool autofill)
        {
            Console.WriteLine("DuoDemension");
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
    
        private void Input()
        {
            Console.WriteLine("Length of your new array: ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Wigth of your new array: ");
            int w = int.Parse(Console.ReadLine());
            duo_arr = new int[l, w];
            for(int i = 0; i < l; i++)
            {
                Console.WriteLine($"{i+1}-ая строка:");
                string[] str = Console.ReadLine().Split(' ');
                for(int j = 0; j<str.Length; j++)
                {
                    duo_arr[i,j] = int.Parse(str[j]);
                }
            }
        }

        private void Random()
        {
            Random rand = new Random();
            int l = rand.Next(2,10);
            int w = rand.Next(2,10);
            duo_arr = new int[l,w];
            for (int i = 0; i < l; i++)
            {
                for(int j = 0; j<w; j++)
                {
                    duo_arr[i,j] = rand.Next(-200, 200);
                }
            }
        }

    }
}