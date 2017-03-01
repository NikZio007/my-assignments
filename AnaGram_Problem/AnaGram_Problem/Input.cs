using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaGram_Problem
{
    class Input
    {
        internal static string[] GetInput()
        {
            String InputString;
            Console.WriteLine("Enter The Anagram Series:");
            InputString = Console.ReadLine();
            String[] InputStringArray = InputString.Split(',');
            return InputStringArray;

        }
    }
}
