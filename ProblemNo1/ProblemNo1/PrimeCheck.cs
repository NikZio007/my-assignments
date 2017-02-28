using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo1
{
    class PrimeCheck
    {
        internal static string CheckForPrimeNumber(int InputNumber)
        {
            int count = 0;
            for (int i = 2; i < InputNumber ; i++)
            {
                if (InputNumber % i == 0)
                {
                    count=1;
                    break;
                }
                
            }
            if (count == 1)
            {
                return "Not PrimeNumber";
            }
            else
            {
                return "PrimeNumber";
            }
           
        }
    }
}
