// Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create first job
        Job job1 = new Job();

        // Set member variables
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        
        // Create second job
        Job job2 = new Job();

        // Set member variables
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create resume instance
        Resume myResume = new Resume();

        // Set the person's name
        myResume._name = "Elizabeth Shonibare";

        // Add jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.Display();

    }
}

