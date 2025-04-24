namespace LengthOfLastWord
{
    public class classholder
    {
        public int lastword(string s)
        {
            int L = s.Length - 1;
            int counter = 0;
            
            while(L >= 0 && s[L] == ' ')
            {
                L--;
            }
            while(L >= 0 && s[L] != ' ')
            {
                counter++;
                L--;
            }
            return counter;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            classholder myclass = new classholder();

            Console.WriteLine(myclass.lastword("hello world"));
        }
    }
}
