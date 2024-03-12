using System;

namespace Gleb
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            IProvider<int> fillInt = new IntProvider();
            IProvider<string> fillString = new StringProvider();
            IProvider<bool> fillBool = new BoolProvider();
            IProvider<double> fillDouble = new DoubleProvider();

            IArray<int> OneDemInt = new OneDem<int>(fillInt); 
            IArray<string> OneDemString = new OneDem<string>(fillString);
            IArray<bool> OneDemBool = new OneDem<bool>(fillBool);
            IArray<double> OneDemDouble = new OneDem<double>(fillDouble);

            IArray<int> DuoDemInt = new DuoDem<int>(fillInt);
            IArray<string> DuoDemString = new DuoDem<string>(fillString);
            IArray<bool> DuoDemBool = new DuoDem<bool>(fillBool);
            IArray<double> DuoDemDouble = new DuoDem<double>(fillDouble);

             IPrinter[] printers = {OneDemInt, OneDemDouble, OneDemBool, OneDemString,
                                    DuoDemInt, DuoDemDouble, DuoDemBool, DuoDemString };
            for (int i = 0; i < printers.Length; i++)
            {
                printers[i].Print();
            }
        }
    }
}
