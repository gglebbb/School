using System;

namespace Gleb
{
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

        public void Create_One_Dem()
        {
            Console.WriteLine("Creating array...");
            Console.WriteLine("Length of your array:");
            int len = int.Parse(Console.ReadLine());
            for(int i = 0; i < len; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
        }    

        public void Mid_Val()
        {
            int allsum = 0;
            foreach (var item in array)
            {
                allsum += Convert.ToInt32(item);
            }
            Console.WriteLine($"Mid value: {allsum/array.Length}");
        }
        public void More_Than_100()
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

            Print_Array(newarr);
        }
        public void MoveOut_Duplicat()
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
            Print_Array(newArr);
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

        private static void Print_Array(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
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
}