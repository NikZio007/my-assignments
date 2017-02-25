using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo1
{
    class Validate
    {
        internal static bool ValidateInputString(string InputString)
        {
            if (!CheckForNumbers(InputString))
            {
                Console.WriteLine("Your String contains Number...!!!");
                return false;
            }

            return true;
        }

        private static bool CheckForNumbers(string InputString)
        {
            foreach(char CharacterInString in InputString)
            {
                if (CharacterInString >= 97 && CharacterInString <= 122 || CharacterInString == 32)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
