using System;

namespace Gleb
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            BaseClass[] arrList = new BaseClass[3];
            arrList[0] = new OneDem();
            arrList[1] = new DuoDem();
            arrList[2] = new JaggedDem();
            for(int i = 0; i<arrList.Length; i++)
            {
                Console.WriteLine($"Information about {arrList[i]}");
                arrList[i].Print();
                arrList[i].MidVal();
            }
            var week = new Weekdays();
            IUnoDem unoDim = (IUnoDem)arrList[0];
            unoDim.DeleteDuplicates();  
            IDuoDem dosDim = (IDuoDem)arrList[1];
            dosDim.Snake();
            IJagDem jagDim = (IJagDem)arrList[2];
            jagDim.ChangeChet();

            IPrinter[] pr = { unoDim, dosDim, jagDim, week };
            foreach (var item in pr)
            {
                item.Print();
            }
        }
    }
}
