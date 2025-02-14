//ben harris
//2/4/2025
using System;
namespace homework82
{
    public class Class1
    {
        public static void Main()
        {
            //declared var
            int PC = -1;
            string Ben = "Ben";
            int N1 = 10;
            int N2 = 16;
            int N3 = 24;
            int N4 = 2;
            int N5 = 20;
            int N6 = 200;
            int N7 = 2;


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
            Console.Write("what is your name sir");
            string UN = Console.ReadLine();
            //Ben discount
            if (Ben == UN)
                N1 = N1 / 2;
            N2 = N2 / 2;
            N3 = N3 / 2;
            N4 = N4 / 2;
            N5 = N5 / 2;
            N6 = N6 / 2;
            N7 = N7 / 2;



            Console.Write("Welcome to my shop pick a number from 1 - 7 to see our prices");
            PC = int.Parse(Console.ReadLine());
            //switch
            switch (PC)
            {
                case 1:
                    Console.WriteLine("rope is " + N1 + " gold");
                    break;
                case 2:
                    Console.WriteLine("torches are " + N2 + " gold");
                    break;
                case 3:
                    Console.WriteLine("climbing gear is " + N3 + " good");
                    break;
                case 4:
                    Console.WriteLine("clean water is " + N4 + " gold");
                    break;
                case 5:
                    Console.WriteLine("Machete is " + N5 + " gold");
                    break;
                case 6:
                    Console.WriteLine("canoe is " + N6 + " gold ");
                    break;
                case 7:
                    Console.WriteLine("Food supplies" + N7 + " gold");
                    break;
                default:
                    Console.WriteLine("i do not know that one");
                    break;



            }

        }
    }
}