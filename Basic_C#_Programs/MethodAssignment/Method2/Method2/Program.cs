using System;
using System.Collections.Generic;
using Method2;

public class Program
{
    public static void Main(string[] args)
    {
     
        Numbers newNumbers = new Numbers();

        //One option to call method and put in parameters
        Console.WriteLine(newNumbers.myMethod1(1,1));
        Console.WriteLine(newNumbers.myMethod1(2.2, 2.2));
        Console.WriteLine(newNumbers.myMethod1("3", "5"));
        Console.ReadLine();

        //Second attempt to call method and put in parameters
        //attempting to convert the method 3 to int from sting in main program
        int num1 = newNumbers.myMethod(9, 0);
        int num2 = newNumbers.myMethod2(2.2, 5.4);
        int num3 = Convert.ToInt32(newNumbers.myMethod3(5, 3));
        Console.WriteLine("Int:" + num1);
        Console.WriteLine("Double:" + num2);
        Console.WriteLine("String to integer:" + num3);
        Console.ReadLine();
             
        
    }
}

  

