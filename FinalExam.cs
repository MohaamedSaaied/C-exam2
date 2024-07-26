using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exam2
{
    internal class FinalExam:Exam
    {
        public List<Question> Questions { get; set; }

        public FinalExam(DateTime TimeOfExam, int NumberOfQuestions, List<Question> questions)
        {
            this.TimeOfExam = TimeOfExam;
            this.NumberOfQuestions = NumberOfQuestions;
            Questions = questions;
        }

        public override void ShowExam()
        {
            string[] answers = new string[NumberOfQuestions + 1];
            int qindex = 0;
            int totalMarks = 0;
            int fullmark = 0;
            Console.WriteLine("Final Exam Questions:");
            foreach (var question in Questions)
            {
                Console.Clear();
                Console.WriteLine($" Mark:{question.Mark} ");
                Console.WriteLine(question);
                Console.WriteLine("Options:");
                int ansid = 1;
                fullmark += question.Mark;
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"{ansid}- {answer.AnswerText}");
                    ansid++;
                }
                Console.WriteLine(" Enter Answer Id ");
                int ans = int.Parse(Console.ReadLine());
                answers[qindex] = question.Answers[ans-1].AnswerText;
                if (ans == question.CorrectAnswer.AnswerId)
                {
                    totalMarks += question.Mark;
                }
                qindex++;
                Console.Clear();
            }
            qindex = 0;
            foreach (var question in Questions)
            {
                Console.WriteLine(question.Body);
                Console.WriteLine($" Your Answer   ===>  {answers[qindex]}");
                Console.WriteLine($" Correct Answer   ===>  {question.CorrectAnswer.AnswerText} ");
                qindex++;
            }
            Console.WriteLine($" Your Grade is {totalMarks} From {fullmark} ");
            Console.WriteLine($" Your Time is {TimeOfExam - DateTime.Now} ");
            Console.WriteLine(" Thank You ");
        }
        }
    }

