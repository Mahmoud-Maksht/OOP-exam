namespace OOPexam.AnswersClasses;

internal class Answer
{
    public string AnswerText;
    public int AnswerId;    
    
    public Answer(string answerText, int answerId)
    {
        AnswerText = answerText;
        AnswerId = answerId;
    }
    public Answer(int answerId)
    {
        AnswerId = answerId;
    }
    public string AnswerTextProperty
    {
        get { return AnswerText; }
        set { if (!string.IsNullOrEmpty(value)) AnswerText = value; }
    }
    public int AnswerIdProperty
    {
        get { return AnswerId; }
        set { AnswerId = value; }
    }
 
}
