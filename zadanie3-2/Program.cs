using System;

namespace Gleb
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Massive[] m = new Massive[3];
            OneDemensionMassive a = new OneDem();
            TwoDemensionMassive b = new DuoDem();
            JaggedMassive v = new JaggedDem();
            m[0] = a;
            m[1] =b;
            m[2] =v;
            foreach(var i in m)
            {
                i.CreateMas();
                i.Print();
                i.MidVal();
            }
        }
    }
}