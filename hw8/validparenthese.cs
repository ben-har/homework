namespace ValidParentheses
{
    public class classholder
    {
        public bool IsValue(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
                for(int j = 0; j < s.Length; j++)
            {
                
                switch(s[i])
                {
                    case '(':
                        if (s[j] == ')')
                        {
                            result++;
                        }
                            
                       break;
                    case '[':
                        if (s[j] == ']')
                        {
                            result++;
                        }

                        break;
                    case '{':
                        if (s[j] == '}')
                        {
                           
                            result++;
                        }
                        break;
                }

                


                
                
                if (result == s.Length / 2)
                {

                    Console.WriteLine(result);
                    return true;
                }
                
            }

            Console.WriteLine(result);
            return false;




        }


        public static void Main()
        {
            classholder myclass = new classholder();

            //()[]{}
            Console.WriteLine(myclass.IsValue("([{}])("));
        }





    }
}
