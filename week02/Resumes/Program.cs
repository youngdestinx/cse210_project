using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Clariontech";
        job1._startYear = 2025;
        job1._endyear = 2027;

        Job job2 = new Job();
        job2._jobTitle = "Programming Teacher";
        job2._company = "Joreb";
        job2._startYear = 2025;
        job2._endyear = 2027;

        Resume resume = new Resume();
        resume._name = "Destiny Linus";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

    }
}