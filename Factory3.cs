using System;
using System.Collections.Generic;
using System.Text;

namespace Paterns1.model
{
    public interface IFan3
    {
        void SwitchOn();
    }
    public interface IKazakhLight
    {
        void Sample();
    }

    class EuroFan : IFan3
    {
        public void SwitchOn()
        {
            throw new NotImplementedException();
        }
    }

    class Kazakh : IKazakhLight
    {
        public void Sample()
        {
            throw new NotImplementedException();
        }
    }

    public interface IElecticalfactory
    {
        IFan3 getFan();
        IKazakhLight getKazakhLight();
    }
    public class KazakhType : IElecticalfactory
    {
        public IFan3 getFan()
        {
            return new EuroFan();
        }

        public IKazakhLight getKazakhLight()
        {
            return new Kazakh();
        }
    }
}
