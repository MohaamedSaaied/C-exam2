using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exam2
{
    internal class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> Answers { get; set; }
        public Answer CorrectAnswer { get; set; }

        public override string ToString()
        {
            return $"{Header}\n{Body}\nMark: {Mark}";
        }
    }
}
