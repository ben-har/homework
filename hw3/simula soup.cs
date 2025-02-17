//Ben Harris
//2/16/25

using System;

public class Class1
{
    enum Type { soup, stew, gumbo };
    enum MainIng {mushrooms, chicken, carrots, potatoes};
    enum Seasoning { spicy, salty, sweet };

    public static void Main(string[] args)
    {
        string TypeT = "";
        string MainIngT = "";
        String SeasoningT = "";
        string playerType = " ";
        string playerMainIng = "";
        string playerSeasoning = " ";

        
        
        
        
        
        
        
        Console.Write("what Type of stew would you want(soup, stew, gumbo) ");
        playerType = Console.ReadLine();
        Console.Write("what Main Ingredaint would you want(mushrooms, chicken, carrots, potatoes) ");
        playerMainIng = Console.ReadLine();
        Console.Write("what seasoning would you want (spicy, salty, sweet) ");
        playerSeasoning = Console.ReadLine();

        switch (playerType)
        {
            case "soup":
                TypeT = playerType;
                break;
            case "stew":
                TypeT = playerType;
                break;
            case "gumbo":
                TypeT = playerType;
                break;
            default:
                TypeT = "undefinded";
                break;







        }

        switch (playerMainIng)
        {

           
            case "mushrooms":
                MainIngT = playerMainIng;
                break;
            case "chicken":
                MainIngT = playerMainIng;
                break;
            case "carrots":
                MainIngT = playerMainIng;
                break;
            case "potatoes":
                MainIngT = playerMainIng;
                break;
            default:
                MainIngT = "undefinded";
                break;










        }

        switch (playerSeasoning)
        {

            case "spicy":
                SeasoningT = playerSeasoning;
                break;
            case "salty":
                SeasoningT = playerSeasoning;
                break;
            case "sweet":
                SeasoningT = playerSeasoning;
                break;
            default:
                SeasoningT = "undefinded";
                break;









        }
        Console.Clear();

        (string, string, string) ListIng = (TypeT, MainIngT, SeasoningT);
        Console.WriteLine("your choice was " + ListIng);


    }
}
