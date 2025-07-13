using  System;

// Define the Job class
public class Resume
{
    // Member variables  to store the person's name
    public string _name = "";
    //Menber variable for the list of jobs,initialized right way
    public List<Job> _jobs = new List<Job>();
    //Method to display resume details
    public void display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        //loop through each job and call its Display method
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }

}