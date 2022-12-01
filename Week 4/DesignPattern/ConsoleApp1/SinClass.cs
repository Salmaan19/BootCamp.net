 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SinClass
    {

        public int MyNumber = 13;

        
        private static SinClass MySingltonInstance = new SinClass();
        private SinClass()
        {


        }

        public static SinClass GetInstance()
        {
            return MySingltonInstance;
        }
    }
}
