using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaGram_Problem
{
    class Validation
    {
        internal bool ValidateTheInpt(string[] InputString)
        {
            bool Checker=true;
            if (!CheckLength(InputString.Length))
            {
                Checker = false;
                return Checker;
            }
            if (!CheckLengthOfElements(InputString))
            {
                Checker = false;
                return Checker;
            }
            if (!CheckForLowerCaseLetter(InputString))
            {
                Checker = false;
                return Checker;
            }
            if (!CheckForDistictValues(InputString))
            {
                Checker = false;
                return Checker;
            }
            
            return Checker;
        }

        private bool CheckLength(int length)
        {
            if (length >= 1 && length <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckLengthOfElements(string[] InputString)
        {
            foreach(string str in InputString)
            {
                if (!(str.Length >= 1 && str.Length <= 50))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckForLowerCaseLetter(string[] InputString)
        {
            foreach (string str in InputString)
            {
                foreach (char c in str)
                {
                    if (!(c >= 97 && c <= 122))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool CheckForDistictValues(string[] InputString)
        {
            string[] Temp= InputString.Distinct().ToArray<string>();
            if ((Temp.Length < InputString.Length))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
