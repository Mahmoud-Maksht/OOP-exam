using OOPexam.QuestionesClasses;
using System.Diagnostics;

namespace OOPexam.ExamClasses;

internal class FinalExam : Exam
{
    public FinalExam(int timeOfExam, int numberOfQuestions, List<Questions> questions) : base(timeOfExam, numberOfQuestions)
    {
        Questions = questions;
    }
    public override void ShowExam()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        List<string> Answers = new List<string>();
        int totalmarks = 0;
        Console.WriteLine("---------- Final Exam ----------");
        Console.WriteLine($"Time of Exam: {TimeOfExamInMinutes} minutes");
        foreach(var question in Questions)
        {
            question.Display();
            Console.WriteLine("Your Answer :");
            string useranswer = Console.ReadLine();
            Answers.Add(useranswer);
        }
        stopwatch.Stop();
        Console.Clear();
        Console.WriteLine("---------- Exam Review ----------");
        Console.WriteLine("Final Exam Review");
        Console.WriteLine($"Exam Duration: {stopwatch.Elapsed.TotalMinutes:F2} minutes");
        Console.WriteLine($"Mark :{totalmarks}");
        for(int i = 0; i < Questions.Count; i++)
        {
            
            Questions[i].DidplayReview(Answers[i], i + 1, true);
            if(Questions[i].CheckAnswer(Answers[i]))
            {
                totalmarks += Questions[i].Marks;
            }
        }
        Console.WriteLine($"Total Marks : {totalmarks}");
    }
}