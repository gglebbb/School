using System;

namespace Gleb
{
    class JaggedDem
    {
        private int height;
        private int[][] jag_arr;
        private int[][] prom;

        public JaggedDem(int height, bool autofill)
        {
            jag_arr = new int[height][];
            if(autofill)
            {
                jag_arr = Input(height);
            }
            else
            {
                jag_arr = RandomInput(height);
            }
        }

        private int[][] Input(int h)
        {
            prom = new int[h][];
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

        private int[][[] RandomInput(int h)]
        {
            prom = new int[h][];
            Random rand = new Random();
            for(int i = 0; i<h; i++)
            {
                int len = rand.Next(1, 6);
                jag_arr[i] = new int[len];
                for(int j = 0; j < len; j++)
                {
                    jag_arr[i][j] = rand.Next(-200,200);
                }
            }
            return prom;
        }

        public void Create_Jag()
        {
            jag_arr = new int[height][];
            for(int i = 0; i < height; i++)
            {
                Console.WriteLine("Creating array...");
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

        public void Print_Jag()
        {
            Console.WriteLine("Your array:");
            for(int i = 0; i < jag_arr.Length; i++)
            {
                Console.Write($"{i}: ");
                for(int j = 0; j<jag_arr[i].Length; j++)
                {
                    Console.Write(jag_arr[i][j] + " ");
                }
                Console.WriteLine("");
            }
        }

        public void Mid_Val_Jag()
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

        public void Mid_Val_In_Each_Jag()
        {
            for(int i = 0;i < jag_arr.Length; i++)
            {
                int allsum_each = 0;
                int counter_each = 0;
                for(int j = 0; j < jag_arr[i].Length; j++)
                {
                    allsum_each += jag_arr[i][j];
                    counter_each++;
                }
                Console.WriteLine($"Mid value in {i} array: {allsum_each/counter_each}");
            }
        }

        public void Change_Even_Values()
        {
            for (int i = 0; i < jag_arr.Length; i++)
            {
                for (int j = 0; j < jag_arr[i].Length; j++)
                {
                    if (jag_arr[i][j] % 2 == 0)
                    {
                        jag_arr[i][j] = i * j;
                    }
                }
            }
        }
    }
}