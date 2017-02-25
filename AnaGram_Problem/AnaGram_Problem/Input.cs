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
            String inputstr;
            Console.WriteLine("-:Enter The Anagram Series:-");
            inputstr = Console.ReadLine();
            String[] InputStringArray = inputstr.Split(',');
            return InputStringArray;

        }
    }
}
