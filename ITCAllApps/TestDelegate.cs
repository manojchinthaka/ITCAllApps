using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ITCAllApps
{
    delegate void NumberChanger(int n);
   public class TestDelegate
    {
        static int num = 10;

        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("This is named method :{0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("This is Named Method: {0}", num);


       }

        public static int getNum()
        {
            return num;
        }


    }
}
