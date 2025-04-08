namespace WhereSpacesAt
{
    public class classHolder
    {
        public int SpaceFinder(string Word, char Space)
        {
            int Result = 1;

            for(int i = 0; i < Word.Length; i++)
            {
               
                if (Word[i] == Space)
                {
                    Result++;

                }





            }

            return Result;





        }









    }
    internal class Program
    {
        static void Main(string[] args)
        {
            classHolder myclass = new classHolder();

            Console.WriteLine(myclass.SpaceFinder("this has four words",' '));
        }
    }
}
