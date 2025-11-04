using System;

class NombrePremier
{

    static void Main()
    {

        bool isFirst = true;
        int i = 2;

        Console.WriteLine("Saisir un entier : ");
        int n = int.Parse(Console.ReadLine());

        while (i < n && isFirst)
        {
            if (n % i == 0)
            {
                isFirst = false;
            }

            i++;
        }

        if (isFirst)
        {
            Console.WriteLine($"{n} est premier !");
        }
        else
        {
            Console.WriteLine($"{n} n'est pas premier !");   
        }

    }

}