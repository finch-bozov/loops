using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Type in a number: ");
        int userNumber = int.Parse(Console.ReadLine());
        for (int i = 1; i <= userNumber; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                if (i < userNumber)
                {
                    Console.Write("{0} ", i);
                }
                else
                {
                    Console.Write("{0}\n", i);
                }
            }
        }
    }
}
