using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCAllApps
{
    public class readOnlyvsConst
    {
        const int cVal = 50;
        static readonly int rVal=50;


        static readOnlyvsConst()
        {
            //cVal = 80;
            rVal = 80;
        }
        public void getConatValue()
        {
            Console.WriteLine(cVal);
        }

        public void getReadonlyValue()
        {         
            Console.WriteLine(rVal);
        }
        public static void getAll()
        {
            Console.WriteLine("");
        }

    }
}
