namespace NumOfBallons
{
    public class ClassHolder
    {
        public int MaxNumberOfBallons(string Word)
        {
            int b = 0, a = 0, l = 0, o = 0, n = 0, result = 0;

            for(int i = 0; i < Word.Length;i++)
            {
                switch(Word[i])
                {
                    case 'b':
                        b++;
                        break;
                    case 'a':
                        a++;
                        break;
                    case 'l':
                        l++;
                        break;
                    case 'o':
                        o++;
                        break;
                    case 'n':
                        n++;
                        break;






                }
                
                




            }
            while (b >= 1 && a >= 1 && l >= 2 && o >= 1 && n >= 1)
            {

                result++;
                b -= 1;
                a -= 1;
                l -= 2;
                o -= 1;
                n -= 1;


            }

            return result;
        
        
        
        
        
        
        }



    }


    internal class Program
    {
        
        static void Main(string[] args)
        {
            ClassHolder myclass = new ClassHolder();

            Console.WriteLine(myclass.MaxNumberOfBallons("baqeollnbaillo n bbbbb"));
        }
    }
}











        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        

