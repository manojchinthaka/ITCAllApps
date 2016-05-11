using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCAllApps
{
    public class Base { }
    public class Derived : Base { }

    delegate void mydelegate(Base b);


    public class MainClass
    {
       

        static void TakeDerived(Derived d)
        {

        }

        static void TakeBase(Base b)
        {

        }

        static void Mainn()
        {
            //mydelegate d1 = TakeDerived;
            //d1(new Derived());
            //d1(new Base()); 
            //mydelegate d2 = TakeBase;
            //d2(new Base());

        }

        
             

    }        
}
