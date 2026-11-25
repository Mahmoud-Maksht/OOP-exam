using OOPexam.ExamClasses;

namespace OOPexam.SubjectClasses;

internal class Subject
{
    public string SubjectName;
    public string SubjectId;
    public Exam ExamOfSubject;
    public Subject(string subjectName, string subjectId, Exam examOfSubject)
    {
        SubjectName = subjectName;
        SubjectId = subjectId;
        ExamOfSubject = examOfSubject;
    }
    public void ExamOfSubjectMethod()
    {
        ExamOfSubject.ShowExam();
    }
}
