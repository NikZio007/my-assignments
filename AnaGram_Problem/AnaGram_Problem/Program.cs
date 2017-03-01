using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaGram_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] InputStringArray;
            bool ResultCheck=true;
            do
            {
                if (ResultCheck == false)
                {
                    Console.WriteLine("Invalid input please enter again");
                }
                InputStringArray = Input.GetInput();
                Validation check = new Validation();
                ResultCheck = check.ValidateTheInpt(InputStringArray);
            } while (ResultCheck == false);
            

            CalculationsForAnagram cal = new CalculationsForAnagram();
            int answer = cal.GetMaximumSubset(InputStringArray);
            Console.WriteLine("Answer iS:- " + answer);
          
        }
    }
}
