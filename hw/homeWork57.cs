//Ben Harris
//1/29/25
using System;
namespace homeWork57
{
    public class Math
    {
        public static void Main()
        {
            Console.Write("how many provencies do you have? ");
            int numberOfprovencies = int.Parse(Console.ReadLine());
            numberOfprovencies *= 6;
            Console.Write("how many duchies do you have? ");
            int numberOfduchies = int.Parse(Console.ReadLine());
            numberOfduchies *= 3;
            Console.Write("how many estates do you have? ");
            int numOfestates = int.Parse(Console.ReadLine());
            Console.WriteLine("points from provencies " + numberOfprovencies);
            Console.WriteLine("points from duchies " + numberOfduchies);
            Console.WriteLine("points from estates " + numOfestates);
        }
    }
}