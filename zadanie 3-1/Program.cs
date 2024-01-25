using System;

namespace Gleb
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("One Dem:");
            One_Dem_func();
            Console.WriteLine("\n"+"Duo Dem:");
            Duo_Dem_func();
            Console.WriteLine("\n"+"Jagged Dem:");
            Jagged_Dem_func();
        }

        static void One_Dem_func()
        {
            bool fill_one = false;
            Console.WriteLine("Array info(length and autofill):");
            string info = Console.ReadLine();
            string[] inf = info.Split(" ");
            if(inf.Length != 1)
            {
                fill_one = bool.Parse(inf[2]);
            }
            OneDem uno = new OneDem(int.Parse(inf[0]), fill_one);
            uno.Print_One();
            uno.More_Than_100();  
            uno.Mid_Val();
            uno.MoveOut_Duplicat();
        }

        static void Duo_Dem_func()
        {
            bool fill_duo = false;
            Console.WriteLine("Array info(length, wigth and autofill):");
            string info = Console.ReadLine();
            string[] inf = info.Split(" ");
            if(inf.Length != 2)
            {
                fill_duo = bool.Parse(inf[2]);
            }
            DuoDem duo = new DuoDem(int.Parse(inf[0]), int.Parse(inf[1]), fill_duo);
            duo.Print_Duo();
            duo.Mid_Val_Duo();
            duo.Print_Revers_Duo();
        }

        static void Jagged_Dem_func()
        {
            bool fill_jag = false;
            Console.WriteLine("Array info(height and autofill):");
            string info = Console.ReadLine();
            string[] inf = info.Split(" ");
            if(inf.Length != 1)
            {
                fill_jag = bool.Parse(inf[1]);
            }
            JaggedDem jag = new JaggedDem(int.Parse(inf[0]), fill_jag);
            jag.Print_Jag();
            jag.Mid_Val_Jag();
            jag.Mid_Val_In_Each_Jag();
            jag.Change_Even_Values();
            jag.Print_Jag();
        }

    }
}