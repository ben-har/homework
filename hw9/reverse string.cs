namespace Reverse_String
{
    public class classholder
    {
        public void reverse(char[] s)
        {
            Stack<char> mystack = new Stack<char>();

            foreach(char c in s)
            { 
               mystack.Push(c);            
            }

            Console.WriteLine(string.Join(", ", mystack));


            

        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            classholder myclass = new classholder();

            char[] j = { 'l', 'u', 'f', 'f', 'y' };

            myclass.reverse(j);

           
        }
    }
}
