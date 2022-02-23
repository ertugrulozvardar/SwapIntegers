using System;

namespace PI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] swapArray = new int[2];

            Console.WriteLine("Please give a number as 1st variable: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give a number as 2nd variable: ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < swapArray.Length - 1; i++) {
                swapArray[i] = b;
                swapArray[i + 1] = a;
            }
            
            a = swapArray[0];
            b = swapArray[1];

            Console.WriteLine("The value of the 1st variable: " + a);
            Console.WriteLine("The value of the 2nd variable: " + b);
        }
    }
}
