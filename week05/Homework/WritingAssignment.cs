using System;
public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // Option A: if _studentName is protected
        return $"{_studentName} - \"{_title}\"";

        // Option B: if using public GetStudentName()
        // return $"{GetStudentName()} - \"{_title}\"";
    }
}
