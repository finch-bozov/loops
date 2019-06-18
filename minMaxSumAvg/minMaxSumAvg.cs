using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Type in how many numbers do you want to input: ");
        int numOfIntegers = int.Parse(Console.ReadLine());
        int min = 0;
        int max = 0;
        int sum = 0;
        double avg = 0;

        for (int i = 0; i < numOfIntegers; i++)
        {
            Console.WriteLine("Type in a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            if (min > userNumber || min == 0)
            {
                min = userNumber;
            }
            if (max < userNumber)
            {
                max = userNumber;
            }
            sum += userNumber;
            avg = sum / (i+1);
        }
        Console.WriteLine("The sum is {0}",sum);
        Console.WriteLine("The average is {0}", avg);
        Console.WriteLine("The min value is {0}", min);
        Console.WriteLine("The max value is {0}", max);
    }
}

