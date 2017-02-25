using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Checker;
            string InputString;
            do
            {
                InputString = Input.GetInputString();
                Checker=Validate.ValidateInputString(InputString);
            } while (Checker == false);

            
             int TotalSum=Calculations.AdditionOfAlphabetsInString(InputString);
             Console.WriteLine(TotalSum);
             Console.WriteLine(PrimeCheck.CheckForPrimeNumber(TotalSum));
            
        }
    }
}
