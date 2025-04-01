namespace Parity
{
    internal class Program
    {
        public class ClassHolder
        {
            public int[] SortArray(int[] array)
            {
                int Temp;
                
                //this needs to be a nested for loop 
                for(int i = 0; i < array.Length; i++)
                { 
                   for(int j = 0; j < array.Length -1; j++)
                    {
                    // have this move over the Character if it is not even
                        int Even = array[j] % 2;
                        int EvenNext = array[j + 1] % 2; 
                        if (Even == 1 && EvenNext == 0)
                        {
                             //4 5
                             // temp = 4
                            Temp = array[j];

                           
                            array[j] = array[j + 1];
                            array[j + 1] = Temp;

                            
                           
                            

                        }


                   }
                }
                return array;




            }






        }
        static void Main(string[] args)
        {
            ClassHolder myclass = new ClassHolder();


            int[] numbers = { 1, 2, 3 , 4, 5 ,6 ,7  };

            int[] SortArray = myclass.SortArray(numbers);

            Console.WriteLine(string.Join(", ", numbers));


        }
    }
}
