//Ben harris
//2/16/25

using System;
using System.Threading;

namespace The_Properties_of_Arrows
{
    public class Arrow
    {
        public string _ArrowHead { get; set; } = " ";
        public string _Fletching { get; set; } = " ";
        public double _Size { get; set; } = 1.0;

        public Arrow()
        {
        }

        public static void Main(string[] args)
        {
            Arrow MyArrow = new Arrow();

            double PlayerSize = 0.0;
            string PlayerFletching = " ";
            double getCost = 0.0;
            double arrowCost = 0.0;

            Console.Write("Pick an arrowhead (steel, wood, or obsidian) ");
            MyArrow._ArrowHead = Console.ReadLine();

            Console.Write("Pick an arrow length between 60 and 100 cm long ");
            PlayerSize = double.Parse(Console.ReadLine());

            Console.Write("Pick a fletching (plastic, turkey feathers, or goose feathers) ");
            PlayerFletching = Console.ReadLine();

            switch (MyArrow._ArrowHead)
            {
                case "steel":
                    getCost += 10.0;
                    break;
                case "wood":
                    getCost += 3.0;
                    break;
                case "obsidian":
                    getCost += 5.0;
                    break;
            }

            switch (PlayerFletching)
            {
                case "plastic":
                    MyArrow._Fletching = "plastic";
                    getCost += 10.0;
                    break;
                case "turkey feathers":
                    MyArrow._Fletching = "turkey feathers";
                    getCost += 5.0;
                    break;
                case "goose feathers":
                    MyArrow._Fletching = "goose feathers";
                    getCost += 3.0;
                    break;
            }

            // This will loop if arrow size isn't correct
            while (PlayerSize < 60 || PlayerSize > 100)
            {
                Console.WriteLine("You need to pick a number between 60 and 100.");
                Thread.Sleep(1000);
                Console.Clear();
                Console.Write("Pick an arrow length between 60 and 100 cm long ");
                PlayerSize = double.Parse(Console.ReadLine());
            }

            if (PlayerSize >= 60 && PlayerSize <= 100)
            {
                MyArrow._Size = PlayerSize;
            }

            arrowCost = MyArrow._Size / 20;
            getCost += arrowCost;

            Console.WriteLine("Your cost is " + getCost);
            Console.WriteLine("Your arrowhead is " + MyArrow._ArrowHead + " your fletching is " + MyArrow._Fletching + " your arrow size is " + MyArrow._Size);
        }
    }
}