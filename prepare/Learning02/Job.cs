using System;
public class Job
{
    //Keeps track of the company, job title, start year, and end year./ 
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;


    //Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}

