using OOPexam.QuestionesClasses;
using System.Diagnostics;

namespace OOPexam.ExamClasses;

internal class ParcticalExam : Exam
{

    public ParcticalExam(int timeOfExamInMinutes, int numberOfQuestions , List<Questions> questions) : base(timeOfExamInMinutes, numberOfQuestions)
    {
        Questions = questions;
    }
    
    public override void ShowExam()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        List<string> Answers = new List<string>();
        int totalmarks = 0;
        Console.WriteLine("--------- Practical Exam ---------");
        Console.WriteLine($"Time {TimeOfExamInMinutes}");
        foreach (var question in Questions)
        {
            question.Display();
            Console.WriteLine(" Enter your Answer : ");
            string userAnswer = Console.ReadLine();
            Answers.Add(userAnswer);
        }
        stopwatch.Stop();
        Console.Clear();
        Console.WriteLine("---------- Exam Review ----------");
        Console.WriteLine("Practical Exam Review");
        Console.WriteLine($"Time Spent: {stopwatch.Elapsed.TotalMinutes:F2} minutes");
        Console.WriteLine($"Mark :{totalmarks}");
        for (int i = 0; i < Questions.Count; i++)
        {
            
            Questions[i].DidplayReview(Answers[i], i + 1,false);
            if(Questions[i].CheckAnswer(Answers[i]))
            {
                totalmarks += Questions[i].Marks;
            }
        }
        Console.WriteLine($"Total Marks : {totalmarks}");
    }
}
