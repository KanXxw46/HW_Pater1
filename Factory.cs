using System;
using System.Collections.Generic;
using System.Text;

namespace Paterns1.model
{
    public enum FanType
    {
        TableFan, PCFan, HairFan,OfficeFan
    }
    public interface IFan
    {
        void ISwitchOn();
        void ISwitchOff();
    }

    public class TableFan : IFan {
        public void ISwitchOff()
        {
            Console.WriteLine("TableFan Switched Off");
        }

        public void ISwitchOn()
        {
            Console.WriteLine("TableFan Switched On");
        }

    }
    public class PCFan : IFan {
        public void ISwitchOff()
        {
            Console.WriteLine("PCFan Switched Off");
        }

        public void ISwitchOn()
        {
            Console.WriteLine("PCFan Switched On");
        }

    }
    public class HairFan : IFan {
        public void ISwitchOff()
        {
            Console.WriteLine("HairFan Switched Off");
        }

        public void ISwitchOn()
        {
            Console.WriteLine("HairFan Switched On");
        }

    }
    public class OfficeFan : IFan
    {
        public void ISwitchOff()
        {
            Console.WriteLine("HairFan Switched Off");
        }

        public void ISwitchOn()
        {
            Console.WriteLine("HairFan Switched On");
        }

    }
    public interface IFanFactory
    {
        IFan CreateFan(FanType fanType);
    }

    public class FanFactory : IFanFactory
    {
        public IFan CreateFan(FanType fanType)
        {
            switch(fanType)
            {
                case FanType.TableFan:
                    return new TableFan();
                case FanType.PCFan:
                    return new PCFan();
                case FanType.HairFan:
                    return new HairFan();
                case FanType.OfficeFan:
                    return new OfficeFan();
                default:
                    return new TableFan();
            }
        }
    }

    /// <summary>
    /// Factory 
    /// 1. Factory Simple 
    /// 2. Factory Method 
    /// 3. Abstract Factory
    /// 
    /// 
    /// FanFactory
    /// 
    /// 
    /// </summary>


}
    

