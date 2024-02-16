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
                arrList[i].Print();
                arrList[i].MidVal();
                Console.WriteLine("Do you want to turn on random generation of arrays?(yes or no)");
                string s = Console.ReadLine().ToLower();
                if(s == "yes")
                {
                    autofill = true;
                }
                else
                {
                    autofill = false;
                }
                arrList[i].CreateMas(autofill);
                arrList[i].Print();
            }
        }
    }
}
