using System;

class Age
{
    static void Main()
    {
        try
        {
            Console.Write("Please enter your birth year: ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.Write("Please enter your birth mouth: ");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.Write("Please enter your birth day: ");
            int birthDay = int.Parse(Console.ReadLine());
            DateTime nowDate = DateTime.Now;
            DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
            int yearNow = nowDate.Year;
            int yearBith = birthDate.Year;
            int age = yearNow - yearBith;
            Console.WriteLine("Your age: {0}.", age);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

    }
}