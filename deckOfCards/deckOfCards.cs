using System;

class Program
{
    static void Main()
    {
        int cardSuite = 4;
        int numOfUniqueCards = 15;
        for (int card = 2; card < numOfUniqueCards; card++)
        {
            String cardName = "";
            if (card == 14)
            {
                cardName = "Ace";
            }
            else if (card == 13)
            {
                cardName = "King";
            }
            else if (card == 12)
            {
                cardName = "Queen";
            }
            else if (card == 11)
            {
                cardName = "Jack";
            }
            else
            {
                cardName = String.Format("{0}", card);
            }

            for (int suite = 0; suite < cardSuite; suite++)
            {

                String fullName = "";
                switch (suite)
                {
                    case 0: fullName += String.Format("{0} of spades, ", cardName); break;
                    case 1: fullName += String.Format("{0} of clubs, ", cardName); break;
                    case 2: fullName += String.Format("{0} of diamonds, ", cardName); break;
                    case 3: fullName += String.Format("{0} of hearts\n", cardName); break;
                    default: cardName += "Invalid!"; break;
                }
                Console.Write(fullName);
            }
        }
    }
}
