namespace Majority_element
{
    public class classholder
    {
        public int majorityReport(int[] opperations)
        {
            int counter = 0;
            int nomanation = 0;

            for(int i = 0;  i < opperations.Length;)
            {
                nomanation = opperations[i];
                for (int j = 0; j < opperations.Length; j++)
                {
                    if (opperations[j] == nomanation)
                    {
                        counter++;
                    }
                    else
                    {
                        counter--;
                    }

                }
                if (counter > 0)
                {
                    return nomanation;
                }
                else
                {
                    i++;
                }
            }
            return -1;




        }








    }
    internal class Program
    {
        static void Main(string[] args)
        {
            classholder myclass = new classholder();

            int[] myopps = { 2, 2, 1, 1, 1, 2, 2 };

            Console.WriteLine(myclass.majorityReport(myopps));
        }
    }
}
