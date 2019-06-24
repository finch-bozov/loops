using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Type in an n number: ");
        int userNumber = int.Parse(Console.ReadLine());
        for (int i = 1; i <= userNumber; i++)
        {
            if (i % 3 > 0 && i % 7 > 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
