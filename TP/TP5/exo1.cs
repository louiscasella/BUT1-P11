using System;

class Exo1
{
    static void Main()
    {
        int[,] tab = {{52,17,54,5,99,81,79,90,39,46},
                      {91,77,90,76,72,31,38,10,82,62},
                      {48,18,13,38,2,85,67,18,67,28},
                      {14,65,9,76,56,86,84,10,75,16},
                      {18,87,17,65,98,88,45,31,14,21},
                      {38,55,76,75,10,33,3,16,3,14},
                      {14,61,23,11,31,25,68,14,19,85},
                      {47,27,35,66,43,61,1,48,39,13},
                      {40,36,3,46,89,59,89,33,65,22},
                      {83,67,6,61,2,57,64,5,34,73}};

        Afficher(tab);
        Console.WriteLine();
        Min(tab);
        Console.WriteLine();
        Max(tab);
        Console.WriteLine();
        Moyenne(tab);
        Console.WriteLine();
        MoyenneParLigne(tab);
    }

    static void Afficher(int[,] tab)
    {
        for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int j = 0; j < tab.GetLength(1); j++)
            {
                Console.Write(tab[i,j]+" ");
            }
            
            Console.WriteLine();
        }
    }

    static void Min(int[,] tab)
    {
        int min = tab[0,0];

        for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int j = 0; j < tab.GetLength(1); j++)
            {
                if (tab[i,j] < min)
                {
                    min = tab[i,j];
                }
            }
        }

        Console.WriteLine($"Le minimum est : {min}");
    }

    static void Max(int[,] tab)
    {
        int max = tab[0,0];

        for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int j = 0; j < tab.GetLength(1); j++)
            {
                if (tab[i,j] > max)
                {
                    max = tab[i,j];
                }
            }
        }

        Console.WriteLine($"Le maximum est : {max}");
    }

    static void Moyenne(int[,] tab)
    {
        double moyenne = 0;

        for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int j = 0; j < tab.GetLength(1); j++)
            {
                moyenne += tab[i,j];
            }
        }

        moyenne /= (tab.GetLength(0) * tab.GetLength(1));

        Console.WriteLine($"La moyenne est de : {moyenne}");
    }

    static void MoyenneParLigne(int[,] tab)
    {
        double moyenne = 0;

        for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int j = 0; j < tab.GetLength(1); j++)
            {
                moyenne += tab[i,j];
            }

            moyenne /= (tab.GetLength(0));
            Console.WriteLine($"La moyenne de la ligne {i+1} est de : {moyenne}");
            moyenne = 0;
        }
    }
}