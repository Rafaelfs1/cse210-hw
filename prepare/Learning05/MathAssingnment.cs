using System;

class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _textbookSection = section;
        _problems = problems;   
    }

    public string GetProblems()
    {
        return _problems;
    }

    public string GetHomeworkList() 
    {
        return $"{base.GetSummary()} {_textbookSection} {_problems}";
    }
}