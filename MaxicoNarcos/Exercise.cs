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

        public string FnLvalueAdd(string FNLadd)
        {
            var valueFnL =
            FNLadd.Substring(0, 1) +
            FNLadd +
            FNLadd.Substring(0, 1);
            return valueFnL;
        }

        //Example - 18:

        public bool PositiveNegative(int a, int b)

        {
            if ((a > 0 && b < 0) || (a < 0 && b > 0))
            {
                Console.WriteLine("Entered Value Is Positive and Negative {0} , {1}", a, b);
                return true;
            }
            else
                Console.WriteLine("Both Values are positive {0} , {1}", a, b);
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

        public int AbsouluteValue(int a, int b)
        {
            if (a > b)
            {
                var diff = a - b;
                var abs = Math.Abs(diff);
                Console.WriteLine("This is Double of Absolute Because Value 01 is greatherthan Value 02: {0} , {1}", a, b);
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

        //Example - 21:
        public bool SumValues(int a, int b)
        {
            if (a == 20 || b == 20 || a + b == 20)
            {
                return true;
            }

            else
                return false;
        }

        //Example - 22:
        public bool Lessthen20(int a)
        {
            if (Math.Abs(a - 100) <= 20 || Math.Abs(a - 200) <= 20)
            {
                return true;
            }

            else
                return false;

        }

        //Example - 24.1 (For Loop):
        public List<string> LongestString(List<string> values)
        {
            var maxListString = new List<string>();
            for (int i = 0; i < values.Count; i++)
            {
                var value = values[i];
                var splitValue = value.Split(" ");
                var ctr = 0;
                var word = string.Empty;
                for (int j = 0; j < splitValue.Length; j++)
                {
                    if (splitValue[j].Length > ctr)
                    {
                        ctr = splitValue[j].Length;
                        word = splitValue[j];

                    }

                }
                maxListString.Add(word);
            }
            return maxListString;
        }

        //Example 24.2 (For Each):
        public List<string> ShortestWord(List<string> ShortValue)
        {
            var minListString = new List<string>();
            foreach (string s in ShortValue)
            {
                var ValueShort = s;
                var SplitShotValue = ValueShort.Split(" ");

                string shortWord = " ";
                var a = SplitShotValue[0].Length;
                foreach (string t in SplitShotValue)
                {
                    if (t.Length <= a)
                    {

                        shortWord = t;
                        a = t.Length;
                    }
                }
                minListString.Add(shortWord);
            }
            return minListString;
        }

        //Example 24.3 (For Loop Shortest)

        public List<string> ShortestByForLoop (List<string> ShortByFor)
        {
            var shortList = new List<string>();
            for (int i = 0; i < ShortByFor.Count; i++)
            {
                var values = ShortByFor[i];
                var splitWord = values.Split(" ");
                int initial = 0;
                var shortWord = string.Empty;
                for (int j = 0; j < splitWord.Length; j++)
                {
                    if (splitWord[j].Length < initial)
                    {
                        initial = splitWord[j].Length;
                        shortWord = splitWord[j];
                    }
                }
                shortList.Add(shortWord);
            }
            return shortList;
        }

    }
}
