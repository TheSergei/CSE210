using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
    

    Job job1 = new Job();
    job1._jobTitle = "software engineer";
    job1._company = "microsoft";
    job1._startYear = 2022;
    job1._endYear = 2024;

    Job job2 = new Job();
    job2._jobTitle = "junior software engineer";
    job2._company = "apple";
    job2._startYear = 2004;
    job2._endYear = 2014;
    

    Resume resume1 = new Resume();
    resume1._name = "sergio";
    resume1._jobs.Add(job2);
    resume1._jobs.Add(job1);
    }
}   
