namespace Baseballsinmymouth
{
    public class classholder
    { 
        public int Baseball(string[] gameimputs)
        {
            int result = 0;

            

            Stack<int> stack = new Stack<int>();

           

            foreach (string i in gameimputs)
            {
                if(int.TryParse(i,out int number))
                {
                    Console.WriteLine(number);
                    stack.Push(number);
                    
                }
                else if(i == "C")
                {
                    stack.Pop();
                }
                else if(i == "D")
                {
                   int num = stack.Pop();
                    num = num * 2;
                    stack.Push(num);

                }
                else if(i == "+")
                {
                    int addingNum = stack.Pop();

                    int combinednum = addingNum + stack.Peek();
                    stack.Push(addingNum);
                    stack.Push(combinednum);

                }






            }

            foreach(int value  in stack)
            {
                
                result = result + value;
            }


            return result;




        }
    
    
    
    
        static void Main()
        {
            classholder myclass = new classholder();

            string[] operations = { "5", "2", "C", "D", "+" };

            Console.WriteLine(myclass.Baseball(operations));


        }
    
    
    }

  
    
}
