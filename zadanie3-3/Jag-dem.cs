using System;

namespace Gleb
{

    public interface IJagDem : IBaseArray
    {
        void ChangeChet();
    }

    public sealed class JaggedDem : BaseClass, IJagDem
    {
        private int[][] jag_arr;
        private int[] prom_o;

        public JaggedDem()
        {
            Console.WriteLine("JaggedDem");
            CreateMas();
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

        protected override void Input()
        {
            Console.WriteLine("Hight of array: ");
            int h = int.Parse(Console.ReadLine());
            jag_arr = new int[h][];
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
                    jag_arr[i] = int_arr;
                }
        }

        protected override void Random()
        {
            Random rand = new Random();
            int h = rand.Next(2,10);
            jag_arr = new int[h][];
            for(int i = 0; i<h; i++)
            {
                int len = rand.Next(1, 6);
                prom_o = new int[len];
                for(int j = 0; j < len; j++)
                {
                    prom_o[j] = rand.Next(-200,200);
                }
                jag_arr[i] = prom_o;
            }        
        }

        public void ChangeChet()
        {
            for (int i = 0; i < jag_arr.Length; i++)
            {
            for (int j = 0; j < jag_arr[i].Length; j++)
                {
                    if (jag_arr[i][j] % 2 == 0)
                    {
                        jag_arr[i][j] = jag_arr[i][j] * j;
                    }
                }
            }
        }

    }
}