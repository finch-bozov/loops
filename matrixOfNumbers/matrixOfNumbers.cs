using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("What is your number: ");
        int userNum = int.Parse(Console.ReadLine());
        for (int row = 1; row <= userNum && row <= 20; row++)
        {
            for (int col = row; col < row + userNum; col++)
            {
                Console.Write("{0,3}", col);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
