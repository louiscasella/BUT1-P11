using System;

class Int7to77
{

    static void Main()
    {

        //boucle iterative Pour
        Console.WriteLine("Boucle For :");

        for (int i = 7; i <= 77; i++)
        {
            Console.Write(i + " ");
        }

        //boucle iterative TantQue
        Console.WriteLine("\nBoucle While :");

        int j = 7;

        while (j <= 77)
        {
            Console.Write(j + " ");
            j++;
        }

        //boucle iterative Do
        Console.WriteLine("\nBoucle Do :");

        int k = 7;

        do
        {
            Console.Write(k + " ");
            k++;
        } while (k <= 77);

        Console.WriteLine();

    }

}