using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exam2
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int SubjectId,string SubjectName) 
        {
            this.SubjectId = SubjectId;
            this.SubjectName = SubjectName;

        }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }
    }
}
