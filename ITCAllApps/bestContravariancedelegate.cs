using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCAllApps
{
    public delegate void myMethod(Toyota value);
    public class bestContravariancedelegate
    {

        public static void functionOne(Car val)
        {

        }
        public static void functionTwo(Toyota val)
        {

        }

        public void mySample()
        {
            myMethod delAbc = functionOne;
            myMethod delXyz = functionTwo;               
        }
    }

    public class Car
    {
    }
    public class Toyota : Car
    {
    }
}
