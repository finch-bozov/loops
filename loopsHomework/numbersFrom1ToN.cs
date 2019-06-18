using System;

namespace loopsHomework
{
    class numbersFrom1ToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a max value: ");
            int maxValue = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= maxValue; i++)
            {
                int counter = 0;
                counter++;
                if (i == maxValue)
                {
                    Console.Write("{0}\n", i);
                }
                else
                {
                    Console.Write("{0}, ", i);
                }
            }
        }
    }
}
