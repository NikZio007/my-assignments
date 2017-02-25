using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Registration
    {
        private List<Subject> FillSubjectList() 
        {
            List<Subject> TempSubjectList=new List<Subject>(2);
            int count=2;
            Console.WriteLine("Fill Subject Deatils:-");
            while (count != 0)
            {
                Subject TempSubject = GetSubjectDetails();
                TempSubjectList.Add(TempSubject);
                count--;
            }
            return TempSubjectList;
        }

        private Subject GetSubjectDetails()
        {
            Console.WriteLine("Enter Subject Name:-");
            string SubjectName = Console.ReadLine();
            Console.WriteLine("Enter Obtained Marks:-");
            string ObtainedMarks = Console.ReadLine();
            Console.WriteLine("Enter Total Marks:-");
            string TotalMarks = Console.ReadLine();
            Validation valid = new Validation();
            if (valid.ValidateTheInput(SubjectName, ObtainedMarks, TotalMarks))
            {
                int Obmarks=int.Parse(ObtainedMarks);
                int Totmarks=int.Parse(TotalMarks);
                return new Subject(SubjectName, Obmarks, Totmarks);
            }
            else
            {
                throw new Exception("Problem registering student..!!");
            }
           
        }

        internal  Student GetStudents() 
        {
            Console.WriteLine("Enter Student Name:-");
            string StudentName=Console.ReadLine();
            List<Subject> SubList=FillSubjectList();
            return new Student(StudentName,SubList);

        }     
    }
}
