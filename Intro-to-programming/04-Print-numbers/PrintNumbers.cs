using System;

class PrintNumbers
{
    static void Main()
    {
        int len = 3;
        string number = "1";
        for(int i = 0; i < len; i++)
        {
            if(i == 0)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.Write("1");
                number = new string('0', i);
                Console.Write(number);
                Console.WriteLine("1");
            }
        }
    }
}
