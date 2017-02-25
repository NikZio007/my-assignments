using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFibonacci_Series
{
    class Validations
    {
        internal static bool ValidateInput(int[] InputToValidate)
        {
            bool checker;
            if (!CheckNull(InputToValidate)) 
            {
                checker = false;
            }
            else if (!CheckBasicSize(InputToValidate.Length))
            {
                checker = false;
            }
            else if (!CheckForMinusValues(InputToValidate))
            {
                checker = false;
            }
            else
            {
                checker = true;
            }
            return checker;
        }

        private static bool CheckBasicSize(int n)
        {
            if (n >= 4 && n <= 20)
            {
                return true;
            }
            else
            {
                Console.WriteLine("TriFibonacci Series Min 4 and Max 20 Strictly");
                return false;
            }
        }

        private static bool CheckNull(int[] ValidateInput)
        {
            if (ValidateInput == null)
            {
         
                return false;
            }
            else
            {
                return true;
            }
           
        }

        private static bool CheckForMinusValues(int[] ValidateInput)
        {
            int count=0;
            foreach (int i in ValidateInput)
            {
                if (i >= -1 && i<100000)
                {
                    if (i == -1)
                    {
                        count++;
                       
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid Input Array");
                    return false;
                   
                }
                
             }

            if (count >= 2)
            {
                 Console.WriteLine("Invalid Input Array Multiple (-1) Found...");
                  return false;
            }
            return true;
        }
    }
}
