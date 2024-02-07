using System;

namespace Gleb
{
    class DuoDem
    {
        public bool autofill = false;
        private int[,] duo_arr;
        private int[,] prom;

        public DuoDem(int length, int wigth, bool autofill)
        {
            duo_arr = new int[length, wigth];
            if(autofill)
            {
                duo_arr = Input(length, wigth);
            }
            else
            {
                duo_arr = RandomInput(length, wigth);
            }
        }

        private int[,] Input(int l, int w)
        {
            prom = new int[l, w];
            for(int i = 0; i < l; i++)
            {
                for(int j = 0; j< w; j++)
                {
                    duo_arr[i,j] = int.Parse(Console.ReadLine());
                }
            }
            return prom;
        }

        private int[,] RandomInput(int l, int w)
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

        public void Create_Duo()
        {
            Console.WriteLine("Creating array...");
            Console.WriteLine("Sixe of your array(length and wigth)");
            string[] arr_inf = Console.ReadLine().Split(" ");
            jag_arr = new int[arr_inf[0], arr_inf[1]];
            for(int i = 0; i < int.Parse(arr_inf[0]); i++)
            {
                for(int j = 0; j< int.Parse(arr_inf[1]); j++)
                {
                    duo_arr[i,j] = int.Parse(Console.ReadLine());
                }
            }        
        }

        public void Print_Duo()
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
        
        public void Print_Revers_Duo()
        {
            Console.WriteLine("Чётные строки пишутся наоборот:");
            for(int i = 0; i < duo_arr.GetLength(0); i++)
            {
                for(int j = 0; j < duo_arr.GetLength(1); j++)
                {
                    if(i % 2 != 0)
                    {
                        Console.Write(duo_arr[i,duo_arr.GetLength(1)-j-1] + " ");
                    }
                    else
                    {
                        Console.Write(duo_arr[i,j]+" ");
                    }
                }
                Console.Write("\n");
            }
        }

        public void  Mid_Val_Duo()
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
    
    }
}