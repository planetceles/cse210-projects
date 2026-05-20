using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Springboard";
        job1._startYear = 2026;
        job1._endYear = 2030;

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "BYU-Pathway";
        job2._startYear = 2030;
        job2._endYear = 2050;

        Resume myResume = new Resume();
        myResume._name = "Celeste Mande";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}