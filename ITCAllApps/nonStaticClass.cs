using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCAllApps
{
   public class nonStaticClass
    {
       

        static nonStaticClass()
        {

        }
        public static void run()
        {
            Console.WriteLine("This is Static Method");
        }
    }
}
