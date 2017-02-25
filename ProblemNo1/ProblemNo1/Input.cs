using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo1
{
    class Input
    {
        internal static string GetInputString()
        {
            Console.WriteLine("Enter The String To Evaluate");
            string input =Console.ReadLine();
            return input.ToLower().Trim();
        }
    }

}
