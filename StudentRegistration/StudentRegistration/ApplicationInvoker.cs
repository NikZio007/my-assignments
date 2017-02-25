using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class ApplicationInvoker
    {
        static void Main(string[] args)
        {
            Registration register = new Registration();
            Display ToDisplay = new Display();
            int choice;
            List<Student> AllStudent = new List<Student>();
            do
            {
                try
                {
                    AllStudent.Add(register.GetStudents());
                    Console.WriteLine("Do you want to Add more to Continue press (0)");
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    choice = 0;
                }
                
            } while (choice == 0);
            ToDisplay.DisplayStudentsList(AllStudent);
          
        }
    }
}
