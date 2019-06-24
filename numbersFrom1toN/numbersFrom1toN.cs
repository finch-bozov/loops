using System;
class numbersFrom1toN
{
    static void Main()
    {
        Console.WriteLine("Type in how many numbers do you want displayed: ");
        int userSpecified = int.Parse(Console.ReadLine());
        for (int i = 1; i <= userSpecified; i++)
        {
            if (i < userSpecified)
            {
                Console.Write("{0} ", i);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}