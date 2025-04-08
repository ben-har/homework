namespace MergeStrings
{
    public class classholder
    {
       public string alternating(string nameOne, string nameTwo)
       {
            int j = 0;
            int i = 0;

            string Result = " ";

            while (i < nameOne.Length && j < nameTwo.Length)
            {
                Result += nameOne[i];
                Result += nameTwo[j];
                i++;
                j++;



            }
            return Result;
       }   

                    




      
    
    
    
    
    
    
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            classholder myclass = new classholder();

            Console.WriteLine(myclass.alternating("1234", "5678"));
        }
    }
}
