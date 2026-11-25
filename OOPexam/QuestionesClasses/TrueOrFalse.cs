using OOPexam.AnswersClasses;
using System.Diagnostics.Contracts;

namespace OOPexam.QuestionesClasses;

internal class TrueOrFalse : Questions
{
   
    
    public TrueOrFalse(string headerOfQuestion, string bodyOfQuestion, int marks , Answer rightAnswer , List<Answer> answers ) : base(headerOfQuestion, bodyOfQuestion, marks , rightAnswer , answers )
    {
        
    }
    public override void Display()
    {
        Console.WriteLine($"Header: {HeaderOfQuestion}");
        Console.WriteLine($"Question : {BodyOfQuestion}");
        foreach (var answer in Answers)
        {
            Console.WriteLine($"- {answer.AnswerId} :: {answer.AnswerText}");
        }
    }
    public override bool CheckAnswer(string userAnswer)
    {
        return int.TryParse(userAnswer, out int answerId) && answerId == RightAnswer.AnswerId;
    }
    public override void DidplayReview(string userAnswer, int questionNumber , bool showDetails)
    {
        if (showDetails)
        {
            Console.WriteLine($"Question {questionNumber}: {BodyOfQuestion}");
            foreach (var answer in Answers)
            {
                Console.WriteLine($"- {answer.AnswerId} :: {answer.AnswerText}");
            }
            Console.WriteLine($"Your Answer: {userAnswer}");
            Console.WriteLine($"Correct Answer: {RightAnswer.AnswerId}");
            int mark = CheckAnswer(userAnswer) ? Marks : 0;
            Console.WriteLine($"Check Answer: {CheckAnswer(userAnswer)} Your Mark : {mark}");
        }
        else
        {

            Console.WriteLine($"Correct Answer: {RightAnswer.AnswerId}");
        } 
    }
}
