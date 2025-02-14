//Writen By Ben Harris
//2/5/25
namespace replicatorofD
{
    internal class Program
    {
        static void Main()
        {
            int[] array = new int[5];
            Console.WriteLine("Enter 5 numbers");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] array2 = new int[5];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array[i];
            }
            Console.WriteLine("\nOriginal Array:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n \nSecond Array");
            foreach(int num in array2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
