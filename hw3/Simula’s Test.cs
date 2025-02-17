//Ben Harris
//2/15/25

using System;

public class Program
{
    
    enum Chest {Open,Closed,Locked,Unlocked }
    


    //make it loop forever
    //go through states of the chest
    //allow the user to move states of the chest
    public static void Main()
    {

       Chest CurrentState = Chest.Locked;
        string UserInput = " ";
        do
        {

            Console.Write("the current state of the chest is " + CurrentState + " would you like to change it ");
            UserInput = Console.ReadLine();
           switch(UserInput)
            {
                case  "Open":
                    if (CurrentState == Chest.Closed || CurrentState == Chest.Unlocked)
                    {
                        CurrentState = Chest.Open;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("the action is imposible");
                        break;
                    }
                case "Closed":

                    if (CurrentState == Chest.Open)
                    {
                        CurrentState = Chest.Closed;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("the action is imposible");
                        break;
                    }
                case "Locked":

                    if (CurrentState == Chest.Closed || CurrentState == Chest.Unlocked)
                    {
                        CurrentState = Chest.Locked;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("the action is imposible");
                        break;
                    }
                case "Unlocked":

                    if (CurrentState == Chest.Closed || CurrentState == Chest.Locked)
                    {
                        CurrentState = Chest.Unlocked;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("the action is imposible");
                        break;
                    }









            }
        }
        while (true);



    }
}