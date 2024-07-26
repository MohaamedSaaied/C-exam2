using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exam2
{
    abstract class Exam
    {
        public DateTime TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }

        public abstract void ShowExam();
    }
}
