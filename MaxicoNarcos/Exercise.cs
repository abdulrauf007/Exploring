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
    }
}
