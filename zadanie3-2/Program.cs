using System;

namespace Gleb
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to turn on random generation of arrays?(yes or no)");
            string ans = Console.ReadLine().ToLower();
            bool autofill = false;
            if (ans == "yes")
            {
                autofill = true;
            }
            BaseClass[] arrList = new BaseClass[3];
            arrList[0] = new OneDem(autofill);
            arrList[1] = new DuoDem(autofill);
            arrList[2] = new JaggedDem(autofill);
            for(int i = 0; i<arrList.Length; i++)
            {
                Console.WriteLine($"Information about {arrList[i]}");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                arrList[i].Print();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                arrList[i].MidVal();
                /*Console.ForegroundColor = ConsoleColor.White;
                arrList[i].CreateMas();
                Console.ForegroundColor = ConsoleColor.Blue;
                arrList[i].Print();*/

            }
        }
    }
}