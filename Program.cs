using System.Collections.Generic;

namespace C_exam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please Enter Subject Id  ");
            int SID = int.Parse(Console.ReadLine());
            Console.WriteLine(" Please Enter Subject Name ");
            string SName = Console.ReadLine();
            Console.WriteLine(" Please Enter type of Exam ");
            Console.WriteLine(" 1 - Pratctical   2 - Final ");
            Subject subject = new Subject(SID, SName);
            int Etype =int.Parse(Console.ReadLine());
            Console.WriteLine(" Please Enter Number Of Questions ");
            int NOQ = int.Parse(Console.ReadLine());
            List<Question> questions = new List<Question>();
            for (int i = 0; i < NOQ; i++)
            {
                if (Etype == 2)  //Final
                {
                    Console.WriteLine(" Please Enter Type Of Questions ");
                    Console.WriteLine(" 1- MCQ   2- True/False ");
                    int QType = int.Parse(Console.ReadLine());
                    if (QType == 1)  //MCQ
                    {
                        Console.WriteLine(" Please Enter the header of the Questions ");
                        string header = Console.ReadLine();
                        Console.WriteLine(" Please Enter the body of the Questions ");
                        string body = Console.ReadLine();
                        Console.WriteLine(" Please Enter the Questions Mark ");
                        int Mark = int.Parse(Console.ReadLine());
                        List < Answer > answers = new List < Answer >();
                        for (int j = 1; j < 4; j++)
                        {   
                            Console.WriteLine($" Please Enter Answer {j} ");
                            string answer=Console.ReadLine();
                            Answer x = new Answer(j,answer);
                            answers.Add(x);
                        }
                        Console.WriteLine(" Please Enter the Correct answer number ");
                        int CA = int.Parse(Console.ReadLine());
                        Question MCQ = new Question
                        {
                            Header = header,
                            Body = body,
                            Mark = Mark,
                            Answers = answers,
                            CorrectAnswer = answers[CA-1]
                        };
                        questions.Add(MCQ);

                    }
                    else if (QType == 2) //TF
                    {
                        Console.WriteLine(" Please Enter the header of the Questions ");
                        string header = Console.ReadLine();
                        Console.WriteLine(" Please Enter the body of the Questions ");
                        string body = Console.ReadLine();
                        Console.WriteLine(" Please Enter the Questions Mark ");
                        int Mark = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Please Enter the Correct answer number ");
                        Console.WriteLine(" 1-True   2-False ");
                        int CAID = int.Parse(Console.ReadLine());
                        Answer CA = new Answer();
                        if (CAID == 1)
                        {
                            CA.AnswerId = CAID;
                            CA.AnswerText = "True";
                        }
                        else if (CAID == 2) 
                        {
                            CA.AnswerId = CAID;
                            CA.AnswerText = "False";
                        }
                        List<Answer> answers = new List<Answer>();
                        Answer x = new Answer(1, "True");
                        answers.Add(x);
                        x = new Answer(2, "Fales");
                        answers.Add(x);
                        var TF = new Question
                        {
                            Header = header,
                            Body = body,
                            Mark = Mark,
                            Answers = answers,
                            CorrectAnswer = CA
                            
                        };
                        questions.Add(TF);

                    }
                }
                else if (Etype == 1)  //Practical
                {
                    Console.WriteLine(" Please Enter the header of the Questions ");
                    string header = Console.ReadLine();
                    Console.WriteLine(" Please Enter the body of the Questions ");
                    string body = Console.ReadLine();
                    Console.WriteLine(" Please Enter the Questions Mark ");
                    int Mark = int.Parse(Console.ReadLine());
                    List<Answer> answers = new List<Answer>();
                    for (int j = 1; j < 4; j++)
                    {
                        Console.WriteLine($" Please Enter Answer {j} ");
                        string answer = Console.ReadLine();
                        Answer x = new Answer(j, answer);
                        answers.Add(x);
                    }
                    Console.WriteLine(" Please Enter the Correct answer number ");
                    int CA = int.Parse(Console.ReadLine());
                    var MCQ = new Question
                    {
                        Header = header,
                        Body = body,
                        Mark = Mark,
                        Answers = answers,
                        CorrectAnswer = answers[CA-1]
                    };
                    questions.Add(MCQ);
                }
            }
            if (Etype == 2)  //Final
            {
                FinalExam FE = new FinalExam(DateTime.Now,NOQ,questions);
                subject.CreateExam(FE);   
                FE.ShowExam();
            }
            else if (Etype == 1)
            {
                PracticalExam PE = new PracticalExam(DateTime.Now, NOQ, questions);
                subject.CreateExam(PE);
                PE.ShowExam();
            }
                


            
        }
    }
}
