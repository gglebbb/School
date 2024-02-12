using System;

namespace Gleb
{
    public sealed class JaggedDem : BaseClass
    {
        private int[][] jag_arr;
        private int[][] prom;
        private int[] prom_o;

        public JaggedDem(bool autofill)
        {
            Console.WriteLine("JaggedDem");
            CreateMas();
        }

        public override void CreateMas()
        {
            Console.WriteLine("Do you want to turn on autofill?(True or False");
            bool auto  = bool.Parse(Console.ReadLine());
            if(auto)
            {
                jag_arr = Random();
            }
            else
            {
                jag_arr = Input();
            }
        }

        public override void Print()
        {
            Console.WriteLine("Your array:");
            for(int i = 0; i < jag_arr.Length; i++)
            {
                Console.Write($"{i+1}-ая строка: ");
                for(int j = 0; j<jag_arr[i].Length; j++)
                {
                    Console.Write(jag_arr[i][j] + " ");
                }
                Console.WriteLine("");
            }
        }

        public override void MidVal()
        {
            int counter = 0;
            int allsum = 0;
            for(int i = 0; i < jag_arr.Length; i++)
            {
                for(int j = 0; j < jag_arr[i].Length; j++)
                {
                    allsum += jag_arr[i][j];
                    counter++;
                }
            }
            Console.WriteLine($"Mid value:{allsum/counter}");
        }

        private int[][] Input()
        {
            Console.WriteLine("Hight of array: ");
            int h = Console.ReadLine();
            for(int i = 0; i < h; i++)
                {
                    Console.WriteLine($"{i+1}-ая строка:");
                    string s = Console.ReadLine();
                    string[] str_arr = new string[s.Split(" ").Length];
                    int[] int_arr = new int[s.Split(" ").Length];
                    str_arr = s.Split(" ");
                    for(int j = 0; j < str_arr.Length; j++)
                    {
                        int_arr[j] = int.Parse(str_arr[j]);
                    }
                    prom[i] = int_arr;
                }
            return prom;
        }

        private int[][] Random()
        {
            Random h = new Random;
            prom = new int[h.Next(2,10)][];
            Random rand = new Random();
            for(int i = 0; i<h; i++)
            {
                int len = rand.Next(1, 6);
                prom_o = new int[len];
                for(int j = 0; j < len; j++)
                {
                    prom_o[j] = rand.Next(-200,200);
                }
                prom[i] = prom_o;
            }
            return prom;
        }

    }
}