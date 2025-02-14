//Ben Harris
//1/29/25

using System;

public class Math
{
    public static void Main()
    {
        Console.Write("how many eggs are there");
        int numberOfeggs = int.Parse(Console.ReadLine());
        Console.Write("how many people want eggs");
        int numberOfpeople = int.Parse(Console.ReadLine());
        int remainder = (numberOfeggs % numberOfpeople);
        Console.WriteLine("the remaining amount is " + remainder);


    }
}