namespace Robot_return_top_origin
{
    public class classHolder
    {
        public bool RobotGrooving(string move)
        {
            bool result = false;
            int x = 0;
            int y = 0;
            for(int i = 0; i< move.Length; i++)
            {
                switch(move[i])
                {
                    case 'u':
                        y++;
                        break;
                    case 'd':
                        y--;
                        break;
                    case 'l':
                        x--;
                        break;
                    case 'r':
                        x++;
                        break;
                    default:
                        Console.WriteLine("do not understand command");
                        break;





                }
                if(x == 0 && y == 0)
                {
                    return result = true;

                }



            }

            return result;



        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            classHolder myclass = new classHolder();

            Console.WriteLine(myclass.RobotGrooving("udlr"));
        }
    }
}
