using System;

class Age
{
    static void Main()
    {
        DateTime birthDate = new DateTime(1998, 04, 20);
        DateTime nowDate = DateTime.Now;
        TimeSpan ageSpan = nowDate.Subtract(birthDate);
        double age = ageSpan.TotalDays / 365;
        Console.WriteLine(age);
    }
}

