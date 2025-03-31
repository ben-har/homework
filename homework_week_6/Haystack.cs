namespace NeedleInHayStack
{
    public class ClassHolder
    {
        public int HayStackFinder(string Haystack, string Needle)
        {
            for(int i = 0; i < Haystack.Length -1; i++)
            {
                if (Haystack[i] == Needle[0])
                    return i;




            }
            return -1;






        }






    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassHolder myClass = new ClassHolder();

            Console.WriteLine(myClass.HayStackFinder("Ben","e"));
        }
    }
}
