using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCAllApps
{

    public class Animal
    {
        string strs { get; set; }
        object objs { get; set; }
        public void Run()
        {
            //Assignment compatibility. 
            string str = "Manoj Weerasooriya from Kandy";
            //An object of a more derived type is assigned to an object of a less derived type. 
            object obj = str;

            strs = "Manoj Weerasooriya";
            objs = strs;

            
 
        }



    }
}
