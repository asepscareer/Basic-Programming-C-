using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int z = x / y;
            try
            {
                Console.WriteLine(z);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
