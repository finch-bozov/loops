using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("How many numbers: ");
        int userNums = int.Parse(Console.ReadLine());
        int evenResult = 1;
        int oddResult = 1;
        for (int i = 1; i <= userNums; i++)
        {
            Console.WriteLine("Write the {0} number: ", i);
            int loopNums = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenResult *= loopNums;
            }
            else if (i % 2 > 0)
            {
                oddResult *= loopNums;
            }
        }
        if (evenResult == oddResult)
        {
            Console.WriteLine("Yes!");
        }
        else if (evenResult != oddResult)
        {
            Console.WriteLine("Nein!!");
        }
        else
        {
            Console.WriteLine("Georgiiiiiiiii");
        }
        Console.WriteLine(evenResult);
        Console.WriteLine(oddResult);
    }
}
