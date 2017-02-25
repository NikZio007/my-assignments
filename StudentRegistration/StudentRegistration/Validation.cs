using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Validation
    {
        internal bool ValidateTheInput(string SubjectName, string ObtainedMarks, string TotalMarks)
        {
            if (!CheckForCharacter(SubjectName))
            {
                Console.WriteLine("Please Enter String!!");
                return false;
            }
            if (!CheckForNumber(ObtainedMarks))
            {
                Console.WriteLine("Please Enter Number!!");
                return false;
            }
            if (!CheckForNumber(TotalMarks))
            {
                Console.WriteLine("Please Enter Number!!");
                return false;
            }
            if (!CheckForValidMarks(ObtainedMarks, TotalMarks))
            {
                Console.WriteLine("Obtained Marks Are greater than Total Marks!!");
            }
    
            return true;
        } 

        private bool CheckForCharacter(string TempString)
        {
            char[] TempCharArray= TempString.ToArray<char>();
            foreach (char TempChar in TempCharArray)
            {
                if ((TempChar >= 65 && TempChar <= 90) || (TempChar >= 97 && TempChar <= 122))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckForNumber(string TempString)
        {
            char[] TempCharArray = TempString.ToArray<char>();
            foreach (char TempChar in TempCharArray)
            {
                if ((TempChar >= 48 && TempChar <= 57))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckForValidMarks(string ObtainedMarks, string TotalMarks)
        {
            int ObtainedMarksInInt = int.Parse(ObtainedMarks);
            int TotalMarksInInt = int.Parse(TotalMarks);
            if(ObtainedMarksInInt> TotalMarksInInt)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
