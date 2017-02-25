using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Student
    {
        private int _StudentID;
        private string _StudentName;
        private List<Subject> _SubjectsInList;
        static int id;

        public string StudentName
        {
            get
            {
                return _StudentName;
            }

            set
            {
                _StudentName = value;
            }
        }

        public List<Subject> SubjectsInList
        {
            get
            {
                return _SubjectsInList;
            }

            set
            {
                _SubjectsInList = value;
            }
        }
        public Student(string name ,List<Subject> NewSubject)
        {
            _StudentID = ++id;
            StudentName = name;
            SubjectsInList = NewSubject;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Clear();
            foreach (Subject TempSubject in SubjectsInList)
            {
                str.Append(TempSubject.ToString());
            }
            
            return _StudentID + " | " + StudentName+" | "+str.ToString();
        }

        
    }
}
