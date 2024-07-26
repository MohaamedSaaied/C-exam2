using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exam2
{
    internal class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Answer()
        {

        }
        public Answer(int id,string tex) 
        {
            AnswerId = id;
            AnswerText = tex;
        }
    }
}
