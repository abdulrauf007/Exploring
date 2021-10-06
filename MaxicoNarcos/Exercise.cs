using System;
using System.Collections.Generic;
using System.Text;

namespace MaxicoNarcos
{
   public class Exercise
    {
        //Example - 15:
        public string Remove(int a, int b, string c)
        {
            if (c.Length > b)
            {
                return c.Remove(a, b);
            }

            else
                return "String is Smallerthan given length";
        }

        //Example - 16:

        public string FnLValueReplaced(string str)
        {
            var value = str.Length > 1 ?
                str.Substring(0, 1) +
                str.Substring(str.Length - 1) +
                str.Substring(2, str.Length - 3) +
                str.Substring(1, 1) : str;
                return value;
        }

        //Example - 17:

        public string FnLvalueAdd (string FNLadd )
        {
            var valueFnL =
            FNLadd.Substring(0, 1) +
            FNLadd +
            FNLadd.Substring(0, 1);
            return valueFnL;
        }

        //Example - 18:

        public bool PositiveNegative (int a, int b)

        {
            if ((a > 0 && b < 0) || (a < 0 && b > 0))
            {
                Console.WriteLine("Entered Value Is Positive and Negative {0} , {1}", a , b);
                return true;
            }
            else
                Console.WriteLine("Both Values are positive {0} , {1}",a , b);
                return false;
        }

        //Example - 19: 

        public int TripleSum(int a, int b)
        {
            if (a == b)
            {
                return 3 * (a + b);
            }
            else
            {
                return a + b;
            }
        }  

        //Example - 20:

        public int AbsouluteValue (int a, int b)
        {
            if (a > b)
            {
                var diff = a - b;
                var abs = Math.Abs(diff);
                Console.WriteLine("This is Double of Absolute Because Value 01 is greatherthan Value 02: {0} , {1}",a , b);
                return 2 * (abs);
            }
            else
            {
                var difference = a - b;
                var difAbs = Math.Abs(difference);
                Console.WriteLine("This Is Absolute Value: {0} , {1}", a, b);
                return (difAbs);
            }
        }




    }
}
