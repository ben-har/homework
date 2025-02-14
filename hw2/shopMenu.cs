//ben harris
//2/4/2025
using System;
namespace homework82
{
    public class Class1
    {
        public static void Main()
        {


            //User Interface
            Console.WriteLine("Welcome to my shop travler");
            Console.WriteLine("option one corn");
            Console.WriteLine("option two torches");
            Console.WriteLine("option three climbing gear");
            Console.WriteLine("option four clean water");
            Console.WriteLine("option five machete");
            Console.WriteLine("option six canoe");
            Console.WriteLine("option seven food supplies");
            //input system
            int PC = -1;
            Console.Write("Welcome to my shop pick a number from 1 - 7 to see our prices");
            PC = int.Parse(Console.ReadLine());
            //switch
            switch (PC)
            {
                case 1:
                    Console.WriteLine("rope is 10 gold");
                    break;
                case 2:
                    Console.WriteLine("torches are 16 gold");
                    break;
                case 3:
                    Console.WriteLine("climbing gear is 24 gold");
                    break;
                case 4:
                    Console.WriteLine("clean water is 2 gold ");
                    break;
                case 5:
                    Console.WriteLine("Machete is 20 gold");
                    break;
                case 6:
                    Console.WriteLine("canoe is 200");
                    break;
                case 7:
                    Console.WriteLine("Food supplies is 2 gold");
                    break;
                default:
                    Console.WriteLine("i do not know that one");
                    break;



            }

        }
    }
}