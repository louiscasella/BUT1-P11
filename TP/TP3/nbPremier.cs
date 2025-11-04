using System;

class NombrePremier
{

    static void Main()
    {

        Console.WriteLine("Saisir borne de debut de votre liste de nombre premier : ");
        int debut = int.Parse(Console.ReadLine());

        Console.WriteLine("Saisir borne de fin de votre liste de nombre premier : ");
        int fin = int.Parse(Console.ReadLine());
        
        Console.WriteLine();

        for (int i = debut; i <= fin; i++)
        {
            if (IsFirst(i) == true)
            {
                Console.WriteLine(i);
            }
        }

    }

    static bool IsFirst(int n)
    {
        bool isFirst = true;
        int i = 2;

        if (n <= 1)
        {
            isFirst = false;
        }
        
        while (i < n && isFirst)
        {
            if (n % i == 0)
            {
                isFirst = false;
            }

            i++;
        }

        return isFirst;
    }

}