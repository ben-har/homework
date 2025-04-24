namespace happy_trails
{
    public class classholder
    {
        public bool ishappy(int n)
        {
            HashSet<int> seen = new HashSet<int>();

            while(n != 1 &&  !seen.Contains(n))
            {
                seen.Add(n);

                n = sumofsquares(n);

            }

            return n == 1;

        }

        public int sumofsquares(int numbers)
        {

            int sum = 0;

            while(numbers > 0)
            {
                int digit = numbers % 10;
                sum += digit * digit;
                numbers /= 10;


            }
            return sum;





        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            classholder myclass = new classholder();
            bool result = myclass.ishappy(n);
            Console.WriteLine($"{n} is a happy number {result}");
        }
    }
}
