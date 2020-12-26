using System;
using System.Collections.Generic;
using System.Text;

namespace Paterns1.model
{
    public interface IFan4
    {
        void Work();
    }
    public class TableFan4 : IFan4
    {
        public void Work()
        {
            Console.WriteLine("Настольный вентилятор работает");
        }
    }
    public class HairFan4 : IFan4
    {
        public void Work()
        {
            Console.WriteLine("Фен работает");
        }
    }
    public class MyFan
    {
        IFan4 Fan;
        public MyFan(IFan4 fan)
        {
            Fan = fan;
        }
        public void  MyFanWork()
        {
            Fan.Work();
        }
    }
}
