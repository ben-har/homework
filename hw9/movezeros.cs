
namespace move_zeors

{
    public class classholder
    {
        public int MoveZeroes(int[] nums)
        {
            for(int i = 0; i < nums.Length;  i++)
            {
                int temp = 0;
                for(int j  = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == 0)
                    {
                        //temp = 1
                        //1,0,0,3,12
                        temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                    }
                    if (nums[i] > nums[j] && nums[i] != 0 && nums[j] != 0)
                    {
                        //0,1,0,3,12
                        temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;

                    }




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

            int[] opperations = { 0, 1, 0, 3, 12 };

            myclass.MoveZeroes(opperations);

            Console.WriteLine(string.Join(",", opperations));
        }
    }
}
