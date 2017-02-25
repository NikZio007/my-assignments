using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Subject
    {
        private string _SubjectName;
        private int _TotalMarks;
        private int _ObtainedMarks;

        public Subject(string SubName,int ObMarks,int TotMarks)
        {
            SubjectName = SubName;
            ObtainedMarks = ObMarks;
            TotalMarks = TotMarks;
        }

        public int ObtainedMarks
        {
            get
            {
                return _ObtainedMarks;
            }

            set
            {
                _ObtainedMarks = value;
            }
        }

        public int TotalMarks
        {
            get
            {
                return _TotalMarks;
            }

            set
            {
                _TotalMarks = value;
            }
        }

        public string SubjectName
        {
            get
            {
                return _SubjectName;
            }

            set
            {
                _SubjectName = value;
            }
        }

        public override string ToString()
        {
            return " | "+SubjectName + " | " + ObtainedMarks + " | " + TotalMarks;
        }
        
    }
    
}
