using System;
public class Assignment
{
    // Private member variables
    //private string _studentName;
    //private string _topic;

    // Constructor
    //public Assignment(string studentName, string topic)
    //{
        //_studentName = studentName;
        //_topic = topic;
    //}

    // Method to get summary
    //public string GetSummary()
    //{
        //return $"{_studentName} - {_topic}";
    //}
     protected string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
