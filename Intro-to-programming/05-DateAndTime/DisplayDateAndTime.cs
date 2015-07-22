using System;

class DisplayDateAndTime
{
    static void Main()
    {
        DateTime dateNow = DateTime.Now;
        int day = dateNow.Day;
        Console.WriteLine(dateNow);
    }
}
