using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCAllApps
{
  
    public class A:IOdd,IEven
    {
        IOdd tetsOdd = new A();
        IEven tetsEven = new A();
 

        public int getevenNumber()
        {
            return 10;
        }

       public int getoddNumber()
        {
            return 5;
        }
       
        public void testApp()
        {

            tetsOdd.getoddNumber();
            tetsEven.getevenNumber();

         }

       
        

    }
}
