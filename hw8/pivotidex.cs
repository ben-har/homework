namespace BaseBall_Game
{
    public class classholder
    {
        public int calPoints(int[] operations)
        {
            int totalsum = operations.Sum();

            int leftsum = 0;

            for (int i = 0; i < operations.Length; i++ )
            {
                int rightside = totalsum - leftsum - operations[i];
                
                if(rightside == leftsum)
                {
                    return i;
                }
                leftsum += rightside;




            }
            return -1;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            classholder myclass = new classholder();

            int[] nums = { 2, 1, -1 };

            Console.WriteLine(myclass.calPoints(nums));
        }
    }
}
