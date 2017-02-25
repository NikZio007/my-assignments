using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFibonacci_Series
{
    class Input
    {

        private static int[] StringToIntArrayConversion(string[] StringtoConvert)
        {
            int[] InputINTArray = new int[StringtoConvert.Length];
            int i = 0;
            int InputNumber;
            foreach (string str in StringtoConvert)
            {
                if (int.TryParse(str, out InputNumber))
                {
                    InputINTArray[i] = InputNumber;
                }
                else
                {
                    Console.WriteLine("Cant Add Double Or Any Other Datatype Except Int In array and It cant Be Blank.");
                    return null;
                }

                i++;
            }
            return InputINTArray;
        }

        internal static int[] GetInput()
        {

            int i = 0;
            Console.WriteLine("Enter the TriFibonacci Series Min 4 and Max 20:-");
            String GetTrifibonacciString = Console.ReadLine();
            string[] InputSring = GetTrifibonacciString.Split(',');
            int[] InputArray = StringToIntArrayConversion(InputSring);
            return InputArray;

        }
    }
}



