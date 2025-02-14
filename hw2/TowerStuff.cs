// Ben Harris
//2/4/2025
using System;

public class Class1
{
    public static void Main()

    {
       
        //declaring x and y values exist
        int Xvalue = -1;
        int Yvalue = -1;
        //player input
        Console.Write("give an x value ");
        Xvalue = int.Parse(Console.ReadLine());

        Console.Write("give a y value ");
        Yvalue = int.Parse(Console.ReadLine());
        //quadrants 
        if (Xvalue < 0 && Yvalue > 0)
        {
            Console.WriteLine("The enemy is northwest! ");

        }
        else if (Xvalue == 0 && Yvalue > 0)
        {
            Console.WriteLine("The enemy is north! ");
        }
        else if (Xvalue > 0 && Yvalue > 0)
        {
            Console.WriteLine("The enemy is northeast!");
        }
        else if (Xvalue < 0 && Yvalue == 0)
        {
            Console.WriteLine("The enemy is west! ");
        }
        else if (Xvalue == 0 && Yvalue == 0)
        {
            Console.WriteLine("you are in the city center, your safe for now.... ");
        }
        else if (Xvalue > 0 && Yvalue == 0)
        {
            Console.WriteLine("The enemy is east! ");
        }
        else if (Xvalue < 0 && Yvalue < 0)
        {
            Console.WriteLine("The enemy is southwest! ");
        }
        else if (Xvalue == 0 && Yvalue < 0)
        {
            Console.WriteLine("The enemy is south! ");
        }
        else if (Xvalue > 0 && Yvalue < 0)
        {
            Console.WriteLine("The enemy is southeast! ");
        }

    }
}
