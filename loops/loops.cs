using System;
using System.Numerics;

class loops
{
    static void Main()
    {
        /*        Console.WriteLine("First While loop");
                int userNumberA = 1;
                int userNumberB = int.Parse(Console.ReadLine());
                int sum = 0;
                while (userNumberA <= userNumberB)
                {
                    sum += userNumberA;
                    userNumberA++;
                }
                Console.WriteLine(sum);*/

        /*        Console.WriteLine("Enter a positive integer");
                int primeNumberInput = int.Parse(Console.ReadLine());
                bool isPrime = false;
                int divider = 2;

                while (divider < primeNumberInput)
                {
                    if (primeNumberInput % divider == 0)
                    {
                        isPrime = false;
                        divider = primeNumberInput; // here we can use "break;"
                    }
                    divider++;
                }
                Console.WriteLine("{0} is prime = {1}", primeNumberInput, isPrime);*/

        /*        Console.WriteLine("Eneter number which you want to have factorial");
                // 5! = 5 * 4 * 3 * 2 * 1
                BigInteger factorialCalculation = int.Parse(Console.ReadLine());
                BigInteger product = 1;*/

        // to use BigInteger one must add System.Numerics in the solution references and then add it in the beginning of the code

        /*while (factorialCalculation > 0)
        {
            product *= factorialCalculation;
            factorialCalculation --;
        }
        Console.WriteLine(product);

        Console.WriteLine("Gib numb a:");
        int minimumUserInput = int.Parse(Console.ReadLine());
        Console.WriteLine("Gib numb b:");
        int maximumUserInput = int.Parse(Console.ReadLine());
        int thisProduct = 1;
        int thisCounter = minimumUserInput;

        do
        {
            thisProduct *= thisCounter;
            thisCounter++;
        }
        while (thisCounter <= maximumUserInput);
        Console.WriteLine(thisProduct);

        int firstForLoopUserInput = int.Parse(Console.ReadLine());
        int forCounter = 0;

        for (int i = 0; i <= firstForLoopUserInput; i++)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                Console.WriteLine(i);
                forCounter++;
            }
        }
        Console.WriteLine(forCounter);*/


        //Console.WriteLine(Math.Pow(2,3));

        /*Console.WriteLine("Type in a number: ");
        int numberForPower = int.Parse(Console.ReadLine());
        Console.WriteLine("To the power of?: ");
        int powerForNumber = int.Parse(Console.ReadLine());

        int powerResult = 1;

        for (int i = 0; i < powerForNumber; i++)
        {
            powerResult *= numberForPower;
        }
        Console.WriteLine(powerResult);*/


        /*//all odd numbers in [1,n] that are not divisors of 7
        Console.WriteLine("Type number for n: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= n; i+=2)
        {
            if (i % 7 == 0)
            {
                continue;
            }
            sum += i;
        }
        Console.WriteLine(sum);*/

        /*        string[] days =
                {
                    "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday",
                };
                foreach (string day in days)
                {
                    Console.WriteLine(day);
                }*/

        /*        int numberOfRows = int.Parse(Console.ReadLine());

                for (int row = 1; row <= numberOfRows; row++)
                {
                    for (int col = 1; col <= row; col++) // the inner (nested) for loop is looped as many times the outer for loop is looped (if outer is looped once, inner will be looped 1*10 number of times)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }*/
        /*
                Console.WriteLine("Enter Min value");
                int min = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Max value");
                int max = int.Parse(Console.ReadLine());

                for (int i = min; i <= max; i++)
                {
                    int divider = 2;
                    bool isPrime = true;

                    while (divider < i)
                    {
                        if (i % divider == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        divider++;
                    }
                    if (isPrime)
                    {
                        Console.WriteLine(i);
                    }
                    //if (j == 15) toBreak = true; break;
                    //if (toBreak) { break; }*/

        for (int a = 1; a < 10; a++)
        {
            for (int b = 0; b < 10; b++)
            {
                for (int c = 0; c < 10; c++)
                {
                    for (int d = 0; d < 10; d++)
                    {
                        if (a + b == c + d)
                        {
                            Console.WriteLine("{0} {1) {2} {3}", a, b, c, d);
                        }
                    }
                }
            }
        }
    }
}
