using System;

public class Class1
{
    public static void Main()

    {
        Console.Title = "clock";
        Console.WriteLine("input Number ");
        int N = int.Parse(Console.ReadLine());

        int X = N % 2;
        Console.WriteLine(X);
        if (X == 0)
            Console.WriteLine("TICK");
        else
            Console.WriteLine("TOCK");
    }
}
