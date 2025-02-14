using System;
//ben harris
//2/5/25
public class Program
{
    public static void Main()
    {
        int Timer = 0;

        while (Timer <= 99 || Timer <= -1)
        {
            Timer++;
            Random random = new Random();
            int randomNumber = random.Next(1, 76);

            if (randomNumber <= 1 || randomNumber >= 25)
            {
                Console.WriteLine(Timer + ": Fire");
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (randomNumber <= 26 || randomNumber >= 50)
            {
                Console.WriteLine(Timer + ": Electric");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
            if (randomNumber <= 51 || randomNumber >= 76)
            {
                Console.WriteLine(Timer + ": normal");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }
    }
}