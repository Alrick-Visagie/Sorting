using System;
using System.Linq;
using System.Text;

namespace Sorting
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public static string RemovePuncAndToLower(string str) 
        {
            string[] punctuationList = { " ", ".", ",", ";", "(", ")", "?" };

            var builder = new StringBuilder(str);

            foreach (var punc in punctuationList)
                builder.Replace(punc, "");

            return builder.ToString().ToLower();
        }

        public static char[] SortUsingLooping(string str) 
        {
            char temp;
         
            char[] charstr = str.ToCharArray();

            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }

            return charstr;
        }

        

        public static char[] SortUsingArraySortMethod(string str)
        {
                      
            char[] charstr = str.ToCharArray();

            Array.Sort(charstr);
            
            return charstr;
        }

        public static string SortUsingLinq(string str)
        {           
            return string.Concat(str.OrderBy(c => c)); 
        }
    }
}
