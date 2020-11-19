using System;
using System.Collections.Generic;
using System.Text;

namespace Method2
{
    public class Numbers
    {
        
        public int myMethod1(int k, int j)
        {
            return k + j;
        }

       
        public int myMethod1(decimal y, decimal r)
        {
            int h = Convert.ToInt32(y - r);
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
