using OOPexam.AnswersClasses;
using OOPexam.ExamClasses;
using OOPexam.QuestionesClasses;
using OOPexam.SubjectClasses;

namespace OOPexam;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your type of exam (1 - for practical, 2 - for final): ");
        Console.Write("Enter your choice: ");
        int examType = int.Parse(Console.ReadLine());
        Console.Clear();
        List<Questions> questions = new List<Questions>();
        if (examType == 1)
        {

            Console.WriteLine("Enter the time of the practical exam in minutes: ");
            int timeOfExam = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of questions in the practical exam: ");
            int numberOfQuestions = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine($"Enter the header of question {i + 1}: ");
                string headerOfQuestion = Console.ReadLine();
                Console.WriteLine($"Enter the body of question {i + 1}: ");
                string bodyOfQuestion = Console.ReadLine();
                Console.WriteLine($"Enter the marks for question {i + 1}: ");
                int marks = int.Parse(Console.ReadLine());
                List<Answer> answers02 = new List<Answer>();
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Enter choice {j + 1} for question {i + 1}: ");
                    string answertext = Console.ReadLine();
                    answers02.Add(new Answer(answertext, (j + 1)));
                }

                Console.WriteLine($"Enter ID of the correct answer for question {i + 1}: ");
                int correctAnswerId = int.Parse(Console.ReadLine());
                Answer rightAnswer = answers02.First(a => a.AnswerId == correctAnswerId);
                Questions question = new Mcq(headerOfQuestion, bodyOfQuestion, marks, rightAnswer, answers02);
                questions.Add(question);
                Console.Clear();
            }
            Console.WriteLine("Do you want to start the exam? (y/n): ");

            string continueChoice = Console.ReadLine();
            ParcticalExam practicalExam = new ParcticalExam(timeOfExam, numberOfQuestions, questions);
            Console.WriteLine("Enter Subject ID: ");
            string subjectId = Console.ReadLine();
            Console.WriteLine("Enter Subject Name: ");
            string subjectName = Console.ReadLine();
            Subject subject = new Subject(subjectName, subjectId, practicalExam);
            Console.Clear();
            if (continueChoice.ToLower() == "y")
            {
                subject.ExamOfSubject.ShowExam();
            }
            else if (continueChoice.ToLower() == "n")
            {
                Console.WriteLine("Exam cancelled.");
            }

        }
        else if (examType == 2)
        {

            Console.WriteLine("Enter the time of the final exam in minutes: ");
            int timeOfExam = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of questions in the final exam: ");
            int numberOfQuestions = int.Parse(Console.ReadLine());
            Console.Clear();
            for(int i = 0; i < numberOfQuestions; i++)
           {
             Console.WriteLine("Do you want (1-T | F or 2-Mcq)?");
             int Choice = int.Parse(Console.ReadLine()); 
             Console.Clear();
             if (Choice == 2)
            {
                    Console.WriteLine("Enter the number of questions for the MCQ section: ");
                    int numberOfQuestionsMcq = int.Parse(Console.ReadLine());
                    for (int j = 0; j < numberOfQuestionsMcq; j++)
                {
                    Console.WriteLine($"Enter the header of question {j + 1}: ");
                    string headerOfQuestion = Console.ReadLine();
                    Console.WriteLine($"Enter the body of question {j + 1}: ");
                    string bodyOfQuestion = Console.ReadLine();
                    Console.WriteLine($"Enter the marks for question {j + 1}: ");
                    int marks = int.Parse(Console.ReadLine());
                    List<Answer> answers02 = new List<Answer>();
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine($"Enter choice {k + 1} for question {j + 1}: ");
                        string answertext = Console.ReadLine();
                        answers02.Add(new Answer(answertext, (k + 1)));
                    }
                    Console.WriteLine($"Enter ID of the correct answer for question {j + 1}: ");
                    int correctAnswerId = int.Parse(Console.ReadLine());
                    Answer rightAnswer = answers02.First(a => a.AnswerId == correctAnswerId);
                    Questions question = new Mcq(headerOfQuestion, bodyOfQuestion, marks, rightAnswer, answers02);
                    questions.Add(question);

                    Console.Clear();
                }
            }

             
            else if (Choice == 1)
            {
                Console.Clear();
                    Console.WriteLine("Enter the number of questions for the T/F section: ");
                    int numberOfQuestionsTf = int.Parse(Console.ReadLine());
                for (int z = 0; z < numberOfQuestionsTf; z++)
                {
                    Console.WriteLine($"Enter the header of question {z + 1}: ");
                    string headerOfQuestion = Console.ReadLine();
                    Console.WriteLine($"Enter the body of question {z + 1}: ");
                    string bodyOfQuestion = Console.ReadLine();
                    Console.WriteLine($"Enter the marks for question {z + 1}: ");
                    int marks = int.Parse(Console.ReadLine());
                        List<Answer> answers02 = new List<Answer>()
                    {
                        new Answer("True", 1),
                        new Answer("False", 2)
                    };
                    Console.WriteLine($"(1-true or 2-false)");
                    Console.WriteLine($"Enter ID of the correct answer for question {z+ 1}: ");
                    int correctAnswerId = int.Parse(Console.ReadLine());
                    Answer rightAnswer = answers02.First(a => a.AnswerId == correctAnswerId);
                    Questions question = new TrueOrFalse(headerOfQuestion, bodyOfQuestion, marks, rightAnswer, answers02);
                    questions.Add(question);
                    Console.Clear();
                }
            }    
           }
            Console.WriteLine("Do you want to start the exam? (y/n): ");
            string continueChoice = Console.ReadLine();
            FinalExam finalExam = new FinalExam(timeOfExam, numberOfQuestions, questions);
            Console.WriteLine("Enter Subject ID: ");
            string subjectId = Console.ReadLine();
            Console.WriteLine("Enter Subject Name: ");
            string subjectName = Console.ReadLine();
            Subject subject = new Subject(subjectName, subjectId, finalExam);
            Console.Clear();
            if (continueChoice.ToLower() == "y")
            {
                subject.ExamOfSubject.ShowExam();
            }
            else if (continueChoice.ToLower() == "n")
            {
                Console.WriteLine("Exam cancelled.");
            }
        }
    }
}

