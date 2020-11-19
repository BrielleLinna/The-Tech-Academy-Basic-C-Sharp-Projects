using System;
using System.Collections.Generic;
using System.Text;

namespace Method2
{
    public class Numbers
    {
       //attempting to make 3 methods, using same int variables to use method overloading?
    public static int myMethod1(int k, int j)
        {
            return k + j;
        }

        //trying to use float with same integers to be able to take in decimals
        public static float myMethod2(int k, int j)
        {
            return k - j;
        }
        //trying to use string with same integers to then attempt to convert to int in main program
    public static string myMethod3(int k, int j)
        {
            //error can't convert string to int implictly
            //I tried to convert when I do console.writeline for this method in main program
            //Perhaps I need to convert within the method itself?
            return k * j;
        }


    
    }
}
