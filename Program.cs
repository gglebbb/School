using System;

namespace Gleb
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            bool fill;
            Console.WriteLine("Array info(length and autofill)");
            string info = Console.ReadLine();
            string[] inf = info.Split(" ");
            if(inf.Length == 1)
            {
                fill = false;
            }
            else
            {
                fill = bool.Parse(inf[1]);
            }
            Duo_Dem(int.Parse(inf[0]), fill);
        }

        static void One_Dem(int len, bool fill)
        {
            OneDem uno = new OneDem(len, fill);
            uno.Print_One();
            uno.MoreThan100();    
        }

        static void Duo_Dem(int len, bool fill)
        {
            DuoDem duo = new DuoDem(len, fill);
            duo.Print_duo();
        }

    }

    class OneDem
    {
        public bool autofill = false;
        private int[] array;

        public OneDem(int length, bool autofill)
        {
            array = new int[length];
            if(autofill)
            {
                for(int i = 0; i < length; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                Random rand = new Random();
                for (int i = 0; i < length; i++)
                {
                    array[i] = rand.Next(-200, 200);
                }
            }
        }

        public void MidVal()
        {
            int allsum = 0;
            foreach (var item in array)
            {
                allsum += Convert.ToInt32(item);
            }
            Console.WriteLine(allsum/array.Length);
        }
        public void MoreThan100()
        {
            int x = 0;
            int counter = 0;
            foreach(var item in array)
            {
                if(item > -100 && item < 100)
                {
                counter++; 
                }
            }
            int[] newarr = new int[counter];
            for(int k = 0; k<array.Length; k++)
            {
                if(array[k] > -100 && array[k] < 100)
                {
                    newarr[x] = array[k];
                    x++;
                }    
            }

            PrintArray(newarr);
        }
        public void MoveOutDuplicat()
        {
            int newArrLen = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        newArrLen--;
                        break;
                    }
                }
            }

            int[] newArr = new int[newArrLen];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = int.MinValue;
            }
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (!Exists(array[i], newArr))
                {
                    newArr[counter] = array[i];
                    counter++;
                }
            }
            PrintArray(newArr);
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

        private static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        public void Print_One()
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    class DuoDem
    {
        public bool autofill = false;
        private int[,] duo_arr;

        public DuoDem(int length, bool autofill)
        {
            int[,] duo_arr = new int[length, length];
            if(autofill)
            {
                for(int i = 0; i < length; i++)
                {
                    for(int j = 0; j< length; j++)
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
                    for(int j = 0; j<length; j++)
                    {
                        duo_arr[i,j] = rand.Next(-200, 200);
                    }
                    
                }
            }
        }

        public void Print_duo()
        {
            for(int i = 0; i < duo_arr.GetLength(0); i++)
            {
                for(int j = 0; j < duo_arr.GetLength(1); j++)
                {
                    Console.Write(duo_arr[i,j]+" ");
                }
                Console.Write("\n");
            }
        }
    }
}
