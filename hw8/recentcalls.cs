namespace recentcalls
{

    public class RecentCounter
    {
        private Queue<int> requests;

        public RecentCounter()
        {
            requests = new Queue<int>();
        }

        public int Ping(int t)
        {
         
            requests.Enqueue(t);

           
            while (requests.Peek() < t - 3000)
            {
                requests.Dequeue();
            }

            
            return requests.Count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var recentCounter = new RecentCounter();
            Console.WriteLine(recentCounter.Ping(1));     
            Console.WriteLine(recentCounter.Ping(100));   
            Console.WriteLine(recentCounter.Ping(3001));  
            Console.WriteLine(recentCounter.Ping(3002));
        }
    }
}
