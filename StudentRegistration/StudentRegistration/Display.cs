using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Display
    {
        internal void DisplayStudentsList(List<Student> StudentsList)
        {
            foreach (Student SingleStudentFromList in StudentsList)
            {
                Console.WriteLine(SingleStudentFromList);
            }
        }
    }
}
