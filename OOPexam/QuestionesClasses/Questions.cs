using OOPexam.AnswersClasses;

namespace OOPexam.QuestionesClasses;

internal abstract class Questions
{
    public string HeaderOfQuestion;
    public string BodyOfQuestion;
    public int Marks;
    public List<Answer> Answers;
    public Answer RightAnswer;
   
    public Questions(string headerOfQuestion, string bodyOfQuestion, int marks , Answer rightAnswer , List<Answer> answers )
    {
        HeaderOfQuestion = headerOfQuestion;
        BodyOfQuestion = bodyOfQuestion;
        Marks = marks;
        RightAnswer = rightAnswer;
        Answers = answers;
    }
    public abstract void Display();
   
    public abstract void DidplayReview(string userAnswer, int questionNumber , bool showDetails);
    public abstract bool CheckAnswer(string userAnswer);
    
    public string HeaderOfQuestionProperty
    {
        get { return HeaderOfQuestion; }
        set { if (!string.IsNullOrEmpty(value)) HeaderOfQuestion = value; }
    }
    public string BodyOfQuestionProperty
    {
        get { return BodyOfQuestion; }
        set { if (!string.IsNullOrEmpty(value)) BodyOfQuestion = value; }
    }
    public int MarksProperty
    {
        get { return Marks; }
        set { if (value >= 0) Marks = value; }
    }
    
}
