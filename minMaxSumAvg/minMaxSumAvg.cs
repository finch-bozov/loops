using System;
<<<<<<< HEAD

=======
>>>>>>> Loops commit from home
class Program
{
    static void Main()
    {
<<<<<<< HEAD
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

=======
        Console.WriteLine("How many numbers do you want: ");
        double userSpecified = double.Parse(Console.ReadLine());
        double min = 0;
        double max = 0;
        double sum = 0;
        double avg = 0;

        for (int i = 1; i <= userSpecified; i++)
        {
            Console.WriteLine("Type in the {0} number: ", i);
            double numbers = double.Parse(Console.ReadLine());
            sum += numbers;
            avg = sum / userSpecified;
            if (min > numbers || min == 0)
            {
                min = numbers;
            }
            if (max < numbers)
            {
                max = numbers;
            }
/*            max = Math.Max(max, numbers);
            min = Math.Min(min, numbers);*/
        }
        Console.WriteLine("This is the sum of the numbers: {0}", sum);
        Console.WriteLine("This is the average: {0}", avg);
        Console.WriteLine("The min number is: {0}", min);
        Console.WriteLine("The max number is: {0}", max);
    }
}
>>>>>>> Loops commit from home
