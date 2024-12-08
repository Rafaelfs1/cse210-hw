using System;

class Assignment    
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getters for studentName and topic
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    // GetSummary method
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}"; 
    }
}


