using System;
using System.Drawing;

public class Arrow
{
    private string _ArrowHead = " ";

    private string _Fletching = " ";

    private double _Size = 1.0;

    public Arrow()
    {
        _Size = 1.0;
    }

    public string GetArrowHead()
    {
        return _ArrowHead;
    }

    public string GetFletching()
    {
        return _Fletching;
    }

    public double GetSize()
    {
        return _Size;
    }

    public static void Main(string[] args)
    {
        Arrow MyArrow = new Arrow();

        string PlayerHead = " ";
        double PlayerSize = 0.0;
        string PlayerFletching = " ";
        double GetCost = 0.0;
        double ArrowCost = 0.0;

        Console.Write("pick an arrowhead(steel, wood, or obsidian) ");
        PlayerHead = Console.ReadLine();

        Console.Write("pick an arrow length between 60 and 100 cm long ");
        PlayerSize = int.Parse(Console.ReadLine());

        Console.Write("pick a fletching (plastic, turkey feathers, or goose feathers) ");
        PlayerFletching = Console.ReadLine();

        switch (PlayerHead)
        {
            case "steel":
                MyArrow._ArrowHead = "steal";
                GetCost = GetCost + 10.0;
                break;
            case "wood":
                MyArrow._ArrowHead = "wood";
                GetCost = GetCost + 3.0;
                break;
            case "obsidian":
                MyArrow._ArrowHead = "obsidian";
                GetCost = GetCost + 5.0;
                break;
        }

        switch (PlayerFletching)
        {
            case "plastic":
                MyArrow._Fletching = "plastic";
                GetCost = GetCost + 10.0;
                break;
            case "turkey feathers":
                MyArrow._Fletching = "turkey feathers";
                GetCost = GetCost + 5.0;
                break;
            case "goose feathers":
                MyArrow._Fletching = "goose feathers";
                GetCost = GetCost + 3.0;
                break;
        }
        while (PlayerSize <= 59 || PlayerSize > 100)
        {
            Console.WriteLine("you need to pick a number between 60 and 100");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("pick an arrow length between 60 and 100 cm long ");
            PlayerSize = int.Parse(Console.ReadLine());
        }
        if (PlayerSize >= 60 && PlayerSize <= 100)
        {
            MyArrow._Size = PlayerSize;
        }
        ArrowCost = MyArrow._Size / 20;
        GetCost = GetCost + ArrowCost;
        Console.WriteLine(GetCost);
    }
}