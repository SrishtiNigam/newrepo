using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum1 = 100;
            float fNum2 = 123.23f;
            double dNum3 = 234432.24;
            char cMyChar = 'S';
            string strData = "Tea";
            string strData1;
            int n;
            double d;
            float f;
            Console.WriteLine("The value of integer in the code is " + iNum1);
            Console.WriteLine("The value {0} is the float value present is " + fNum2);
            Console.WriteLine("The value "+dNum3+" is the double value present");
            Console.WriteLine("The character value present "+cMyChar);
            Console.WriteLine("The string value present "+strData);
            Console.WriteLine("This is the output statement");
            Console.WriteLine("Please Enter some string");
            strData1 = Console.ReadLine();
            Console.WriteLine("Please Enter an integer");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter some double value");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter some float value");
            f = float.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter some character");
            char ch = Console.ReadLine()[0];
            Console.ReadKey();
        }
    }
}
