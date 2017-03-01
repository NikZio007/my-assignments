using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaGram_Problem
{
    class CalculationsForAnagram
    {
        internal int GetMaximumSubset(string[] InputStringArray)
        {
            int count;
            if (!CheckLengthOfEachElement(InputStringArray, out count))
            {
                return count;

            }
            else
            {
                for (int i = 0; i < InputStringArray.Length; i++)
                {
                    char[] TempCharArray=InputStringArray[i].ToCharArray();
                    Array.Sort<char>(TempCharArray);
                    InputStringArray[i] = CharArrayToStringConvertor(TempCharArray);
                    
                }

                int answer=InputStringArray.Distinct<string>().ToArray<string>().Length;
                return answer;
            }
            
        }

        internal bool CheckLengthOfEachElement(string[]  InputStringArray,out int count)
        {
            
            int[] sizeArray = new int[InputStringArray.Length];
            int i=0;
            foreach (string str in InputStringArray)
            {
                sizeArray[i] = str.Length;
                i++;
            }
            var z = sizeArray.Distinct().ToArray<int>();
            if (z.Length==sizeArray.Length)
            {
                count = z.Length;
                return false;
            }
            count = z.Length;
            return true;
        }

        private string CharArrayToStringConvertor(char[] TempCharArray)
        {
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            foreach (char Character in TempCharArray)
            {
                sb.Append(Character);
            }
            return sb.ToString();
        }
    }
}
