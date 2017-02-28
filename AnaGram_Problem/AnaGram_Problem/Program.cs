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
        Start:
            string[] inputStringArray = Input.GetInput();
            Validation check = new Validation();
            bool chk = check.ValidateTheInpt(inputStringArray);
            if (chk)
            {
                Console.WriteLine("All Good To Go");
                CalculationsForAnagram cal = new CalculationsForAnagram();
                int answer = cal.GetMaximumSubset(inputStringArray);
                Console.WriteLine("Answer iS:- " + answer);
            }
            else
            {
                Console.WriteLine("Nothing is Good right now");
                goto Start;
            }
            Console.ReadKey();
        }
    }
}
