using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethod
{
    public class Numbers
    {
     
        public int myMethod1(int k)
        {
            return k + 10;
        }

        public int myMethod1(double k)
        {
            int h = Convert.ToInt32(k -5);
            return h;
        }
         
        public int myMethod1(string k)
        {
            int n;
            bool isTrue = Int32.TryParse(k, out n);
            if (isTrue)
            {
                return n;
            }
            else
            {
                Console.WriteLine("This can not be converted.");
                return 0;
            }

        }
    }
    
}
