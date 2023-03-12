using System;

public class MathAssignement : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignement(string textbookSection, string problems, string studentName, string topic)
    : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return "Section " + _textbookSection + " Problems " + _problems;
    }
}