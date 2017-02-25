using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo1
{
    class Calculations
    {
        internal static int AdditionOfAlphabetsInString(string InputString)
        {
            int Addition = 0;
            foreach (char InputCharacter in InputString)
            {
                if (InputCharacter == 32)
                {
                    continue;
                }
                else
                {
                    Addition += (Convert.ToInt32(InputCharacter)) - 96;
                }
            }
            return Addition;
        }
    }
}
