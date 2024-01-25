using System;

namespace Gleb
{
    class DuoDem
    {
        public bool autofill = false;
        private int[,] duo_arr;

        public DuoDem(int length, int wigth, bool autofill)
        {
            duo_arr = new int[length, wigth];
            if(autofill)
            {
                for(int i = 0; i < length; i++)
                {
                    for(int j = 0; j< wigth; j++)
                    {
                        duo_arr[i,j] = int.Parse(Console.ReadLine());
                    }
                    
                }
            }
            else
            {
                Random rand = new Random();
                for (int i = 0; i < length; i++)
                {
                    for(int j = 0; j<wigth; j++)
                    {
                        duo_arr[i,j] = rand.Next(-200, 200);
                    }
                    
                }
            }
        }

        public void Create_Duo()
        {
            Console.WriteLine("Creating array...");
            Console.WriteLine("Sixe of your array(length and wigth)");
            string[] arr_inf = Console.ReadLine().Split(" ");
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
            Console.WriteLine("Ypur array:");
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