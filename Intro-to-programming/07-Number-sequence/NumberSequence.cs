using System;

class NumberSequence
{
    static void Main()
    {
        int number = 2;
        for(int i = 0; i < 100; i++)
        {
            if(number % 2 == 0)
            {
                Console.Write(number);
            }
            else
            {
                Console.Write(-number);
            }
            Console.Write(" ");
            number++;
        }
    }
}
