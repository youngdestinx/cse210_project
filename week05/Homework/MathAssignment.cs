using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;

    public MathAssignment(string name, string topic, string section, string problem) : base(name, topic)
    {
        _textbookSection = section;
        _problem = problem;
    }

    public string GetHomeWorkList()
    {
        string details = base.GetSummary();
        return details + " " + _textbookSection + " " + _problem;
    }
}