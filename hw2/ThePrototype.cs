using System;
// ben harris
//2/5/2025
public class Program
{
    public static void Main()
    {
        int playerIntOne;
        int playerIntTwo;
        do
        {
            Console.WriteLine("Player One guess the number between 1-100");
            string playerResponse = Console.ReadLine();
            playerIntOne = Convert.ToInt32(playerResponse);
            if (playerIntOne < 64)
            {
                Console.WriteLine("that number is to low");
            }
            if (playerIntOne > 64)
            {
                Console.WriteLine("that number is to high");
            }
            if (playerIntOne == 64)
            {
                Console.WriteLine("thats the correct number, this window will close in 5 seconds.");
                Thread.Sleep(5000);
                Console.Clear();
                break;
            }
            Console.WriteLine("Player two guess the number between 1-100");
            string playerResponseTwo = Console.ReadLine();
            playerIntTwo = Convert.ToInt32(playerResponseTwo);
            if (playerIntTwo < 64)
            {
                Console.WriteLine("that number is to low");
            }
            if (playerIntTwo > 64)
            {
                Console.WriteLine("that number is to high");
            }
            if (playerIntTwo == 64)
            {
                Console.WriteLine("thats the correct number, this window will close in 5 seconds.");
                Thread.Sleep(5000);
                Console.Clear();
                
                break;
            }
        }
        while (playerIntOne != 64 || playerIntTwo != 64);
    }
}