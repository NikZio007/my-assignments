using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFibonacci_Series
{
    class CalculateFibbo
    {
        internal int complete(int[] InputArray)
        {
            int index = Array.IndexOf(InputArray, -1);
            if(index >= 2)
            {
                if (index <= InputArray.Length - 2)
                {
                    InputArray[index] = InputArray[index + 1] - (InputArray[index - 1] + InputArray[index - 2]);
                }

            }
            if(index == 0)
            {
                InputArray[index] = (InputArray[index + 3] - InputArray[index + 2] - InputArray[index + 1]);
            }
            if (index == 1)
            {
                InputArray[index] = InputArray[index + 2] - InputArray[index + 1] - InputArray[index - 1];
            }
            if (index == (InputArray.Length) - 1)
            {
                InputArray[index] = InputArray[index - 3] + InputArray[index - 2] + InputArray[index - 1];
            }


            if (!CheckTheReplacedSeries(InputArray))
            {
                return -1;
            }

            return InputArray[index];
        }

        private bool CheckTheReplacedSeries(int[] InputArray)
        {
            for (int i = 3; i < InputArray.Length; i++)
            {
                if (InputArray[i] != InputArray[i - 1] + InputArray[i - 2] + InputArray[i - 3])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
