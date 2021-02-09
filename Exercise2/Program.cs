using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input Angka: ");
                int inputAngka = Convert.ToInt32(Console.ReadLine());
                String genap = "";
                String ganjil = "";
                // Angka Ganjil
                Console.WriteLine("1-2. Menampilkan  Ganjil Genap");
                Console.WriteLine("============================");
                for (int i = 1; i <= inputAngka; i++)
                {
                    if (i % 2 == 1)
                    {
                        ganjil = ganjil + i + " ";
                    }
                    else
                    {
                        genap = genap + i + " ";
                    }
                }
                Console.WriteLine("Bilangan Ganjil = " + ganjil);
                Console.WriteLine("Bilangan Genap = " + genap);
                //Menampilkan Bilangan Prima
                Console.WriteLine("3. Menampilkan Bilangan Prima");
                Console.WriteLine("============================");
                for (int i = 1; i < inputAngka; i++)
                {
                    int isPrime = 0;
                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                            isPrime++;
                        if (isPrime == 2)
                            break;
                    }
                    if (isPrime != 2)
                        Console.Write(i + " ");
                    isPrime = 0;
                }
                Console.WriteLine();
                Console.WriteLine("4. Menampilkan Bilangan Fibonanci");
                Console.WriteLine("============================");
                int n1 = 0, n2 = 1, n3;
                for (int i = 1; i < 7; i++)
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }
                Console.WriteLine();
                Console.WriteLine("5. Menampilkan Kata berdasarkan kelipatan");
                Console.WriteLine("============================");
                for (int i = 1; i <= inputAngka; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write("Metrodata, ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("Data, ");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("Metro, ");
                    }
                    else
                    {
                        Console.Write(i + ", ");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
