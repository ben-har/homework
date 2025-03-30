using System.Linq;

namespace Two_Sum
{
    public class TwoSum
    {
        public List<int> TargetValues(List<int> values, int target)
        {
            List <int> result = new List<int>();
            for (int i = 0; i < values.Count; i++)
                for(int j = i + 1; j < values.Count; j++)
                {
                    if (values[i] + values[j] == target)
                    {
                        result.Add(values[i]);
                        result.Add(values[j]);

                        return result;
                    }
                    



                }
            
            return result;




        }
    }   
    internal class Program
    {
        static void Main()
        {
            TwoSum myTwoSum = new TwoSum();
            List <int> Replacement = new List<int> {1,2,3,4,5,6,7,8,9,10 };

            Console.Write("what do you want the target number to be ");
            int target = int.Parse(Console.ReadLine());

            List<int> result = myTwoSum.TargetValues(Replacement, target);

            foreach (var value in result)
            {
                Console.Write( value);

            }



        }
    }
}
