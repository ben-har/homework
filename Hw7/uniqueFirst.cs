namespace FirstUnique
{
    public class classHolder
    {
        public int Unique(string name, char Letter)
        {
            for(int i = 0; i < name.Length; i++)
            {
                if (name[i] == Letter)
                {
                    
                    return i;
                    


                }





                

            }

            return -1;






        }









    }
    internal class Program
    {
        static void Main(string[] args)
        {
            classHolder myclass = new classHolder();

            Console.WriteLine(myclass.Unique("loveleetcode", 'l'));
        }
    }
}
