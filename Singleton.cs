using System;
using System.Collections.Generic;
using System.Text;

namespace Paterns1.model
{
    class Singleton
    {
        
        static Singleton Instance;
        public static Singleton CreateOrGetInstence()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
                return Instance;
            }
            else
                return Instance;
        }
        private Singleton()
        { }
        public override string ToString()
        {
            return "Singleton wos created";
        }
    }
}
