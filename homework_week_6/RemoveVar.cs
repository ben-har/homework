namespace RemoveVar
{
    public class ClassHolder
    {
        public int elementRemover(string[] Holder, int val)
        {
            int Remaining = Holder.Length;

            for (int i = 0; i < Holder.Length; i++)
            {
                if (Holder[i] == val.ToString())
                {
                    Holder[i] = "_";
                    Remaining--;

                }




            }
            return Remaining;

        }
        






    }
    
    internal class Program
    {


        static void Main(string[] args)
        {
            ClassHolder myClassholder = new ClassHolder();

            Console.WriteLine(myClassholder.elementRemover(["1","3","6","7","5","6"], 6));
        }
    }
}




   
