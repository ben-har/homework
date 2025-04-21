 namespace eat_sandwhich
{
    public class classholder
    {
        public int CountStudent(int[] students, int[] sandwhich)
        {
            Queue<int> myqueue = new Queue<int>(students);

            int index = 0;
            int failure = 0;

            while (myqueue.Count > 0 && failure > 0)
            {
                if(myqueue.Peek() == students[index])
                {
                    index++;
                    myqueue.Dequeue();
                    failure = 0;

                }
                else
                {
                    failure++;


                }
                




            }
            return myqueue.Count;

        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            classholder myclass = new classholder();

            int[] mystudent = { 1, 1, 1, 0, 0, 1 };

            int[] mysandwhich = { 1, 0, 0, 0, 1, 1 };
            Console.WriteLine(myclass.CountStudent(mystudent, mysandwhich));
        }
    }
}
