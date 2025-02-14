//Ben Harris
//1/29/25
using System;
namespace homeWork68Basic
{
    public class Math
    {
        public static void Main()
        {
            Console.Title = "The Defense of Consolas";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine("the point of this game is to defend the city by placing a sqaud in the four tiles around your coradanates");
            Console.WriteLine();



            int columnUp = 0;
            int columnDown = 0;
            int rowLeft = 0;
            int rowRight = 0;

            Console.Write("place a row ");
            int Row = int.Parse(Console.ReadLine());

            Console.Write("place a column ");
            int Column = int.Parse(Console.ReadLine());

            columnUp = Column - 1;
            columnDown = Column + 1;
            rowLeft = Row + 1;
            rowRight = Row - 1;

            Console.Beep(440, 500);
            Console.WriteLine("==========");

            Console.WriteLine("your cities location is " + Row + " , " + Column);
            Console.WriteLine("============");
            Console.WriteLine("troop locations");
            Console.WriteLine(Row + "," + columnUp);
            Console.WriteLine(Row + "," + columnDown);
            Console.WriteLine(rowLeft + "," + Column);
            Console.WriteLine(rowRight + "," + Column);



        }
    }
}