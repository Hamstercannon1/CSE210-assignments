using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software engineer";
        job1._company = "Microsoft";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Peasant";
        job2._company = "France";
        job2._startYear = 1413;
        job2._endYear = 1417;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";   
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.displayJobDetails();


    }
}