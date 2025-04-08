namespace Difference
{
    public class ClassHolder
    {
        public string Finder(string difference, string orginal)
        {
            
            int i = 0;
            int j = 0;
            while(i < orginal.Length && j < orginal.Length)
            {
                if (orginal[i] != difference[j])
                {
                    return difference[j].ToString();


                }
                i++;
                j++;

            }

            return "no difference bewteen the loops";

        }






    }
    internal class Program
    {
        static void Main(string[] args)
        {

            ClassHolder myclass = new ClassHolder();

            Console.WriteLine(myclass.Finder("abced", "abcde"));



        }
    }
}
