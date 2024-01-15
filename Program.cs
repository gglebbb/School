using System;

namespace Gleb
{
    class Mainclass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Array info(length and autofill)");
            string info = Console.ReadLine();
            string[] inf = info.Split(" ");
            OneDem uno = new OneDem(int.Parse(inf[0]), bool.Parse(inf[1]));
            uno.Print_1();
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
            int counter =0;
            foreach(var item in array)
            {
                if(item > -100 && item < 100)
                {
                counter++; 
                }
            }
            int[] newarr = new int[counter];
            for(int k = 0;k<counter; k++)
            {
                if(newarr[k] > -100 && newarr[k] < 100)
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
                        newArrayLen--;
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
        public void Print_1()
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
