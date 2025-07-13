using System;

// Define the Job class
public class Job
{
    // Member variables should be outside Main and inside the class
    public string _jobTitle = "";
    public string _company = "";
    public int _startYear;
    public int _endYear;

    

    // Method to display job info
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

// Program entry point should be in a separate class
