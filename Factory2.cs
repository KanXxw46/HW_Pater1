using System;
using System.Collections.Generic;
using System.Text;

namespace Paterns1.model
{
    public interface IFan2
    {
        void SwitchOn();
        void SwitchOff();
    }
     class Factory2 : IFan2
    {
        public void SwitchOff()
        {
            throw new NotImplementedException();
        }

        public void SwitchOn()
        {
            throw new NotImplementedException();
        }
    }
     class TableFan2 : IFan2
    {
        public void SwitchOff()
        {
            throw new NotImplementedException();
        }

        public void SwitchOn()
        {
            throw new NotImplementedException();
        }
    }
    public class PCFan2 : IFan2
    {
        public void SwitchOff()
        {
            throw new NotImplementedException();
        }

        public void SwitchOn()
        {
            throw new NotImplementedException();
        }
    }
    public class HairFan2 : IFan2
    {
        public void SwitchOff()
        {
            throw new NotImplementedException();
        }

        public void SwitchOn()
        {
            throw new NotImplementedException();
        }
    }

    class AutoFan2 : IFan2
    {
        public void SwitchOff()
        {
            throw new NotImplementedException();
        }

        public void SwitchOn()
        {
            throw new NotImplementedException();
        }
    }

    public interface IFanFactory2
    {
        IFan2 CreateFan();
    }

    class TableFanFactory : IFanFactory2
    {
        public IFan2 CreateFan()
        {
            throw new NotImplementedException();
        }
    }
    class PCFanFactory : IFanFactory2
    {
        public IFan2 CreateFan()
        {
            throw new NotImplementedException();
        }
    }
    class HairFanFactory : IFanFactory2
    {
        public IFan2 CreateFan()
        {
            throw new NotImplementedException();
        }
    }
    class AutoFanFactory : IFanFactory2
    {
        public IFan2 CreateFan()
        {
            throw new NotImplementedException();
        }
    }
}
