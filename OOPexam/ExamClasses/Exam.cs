using OOPexam.QuestionesClasses;

namespace OOPexam.ExamClasses;

internal abstract class Exam
{
    public int TimeOfExamInMinutes;
    public int NumberOfQuestions;
    public List<Questions> Questions { get; set; }
    public Exam(int timeOfExam, int numberOfQuestions)
    {
        TimeOfExamInMinutes = timeOfExam;
        NumberOfQuestions = numberOfQuestions;
        Questions = new List<Questions>();
    }
    public abstract void ShowExam();
   
    public int TimeOfExamInMinutesProperty
    {
        get { return TimeOfExamInMinutes; }
        set { if (value > 30 && value < 180) TimeOfExamInMinutes = value; }
    }
  public int NumberOfQuestionsProperty
    {
        get { return NumberOfQuestions; }
        set { if (value > 0) NumberOfQuestions = value; }
    }   
}
