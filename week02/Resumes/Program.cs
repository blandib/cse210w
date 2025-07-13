using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        // Create a Job instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Deloitte";
        job2._startYear = 2020;
        job2._endYear = 2024;

        Job job3 = new Job();
        job3._jobTitle = "Marketing Manager";
        job3._company = " Unilever";
        job3._startYear = 2023;
        job3._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Blandine Bukasa lusamba";
        //Add jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        //Access and Display the First Job Title Using Dot Notation
        //Console.WriteLine(myResume._jobs[0]._jobTitle);
        // Display job info
        //job1.Display();
        //job2.Display();
        //job3.Display();
        //Display full resume
        myResume.display();
    }
}