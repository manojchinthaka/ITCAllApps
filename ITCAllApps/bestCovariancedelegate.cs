using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCAllApps
{
   public delegate Car mydelconMethod();
   public delegate Toyota mydelcontoyotaMethod();
    public class bestCovariancedelegate
    {
        public Car methodOne()
        {
            return new Car();
        }
        public Toyota methodTwo()
        {
            return new Toyota();
        }


        public void myfuncTest()
        {

            mydelconMethod testDelegateone = methodOne;
            mydelconMethod testDelegatetwo = methodTwo;

            //This is wrong
            //mydelcontoyotaMethod mycar = methodOne;
            mydelcontoyotaMethod myToyota = methodTwo;



        }


    }
}
