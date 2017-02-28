using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFibonacci_Series
{
    class Program
    {
        static void displayArray(int[] InputArray)
        {
            foreach (int i in InputArray)
            {
                Console.Write(i);
            }
        }

        static int PositionOfMinus(int[] InputArray)
        {
            
            for(int i=0;i<InputArray.Length;i++)
            {
                if (InputArray[i] == -1)
                {
                    return i;
                }
             
            }
            return 0;
        }

        static void Main(string[] args)
        {
            PleaseEnter:
            Console.WriteLine("Welcome User!!!");
            int[] InputArray = Input.GetInput();
            if (Validations.ValidateInput(InputArray))
            {
                CalculateFibbo calculate = new CalculateFibbo();
                int Result = calculate.complete(InputArray);
                Console.WriteLine(Result);

            }
            else
            {
                goto PleaseEnter;
            }

        }
    }
}
