using System;

class Fibonnaci
{
    static void Main()
    {
        int [] tab = new int[20];

        tab[0] = 0;
        tab[1] = 1;

        for (int i = 2; i < tab.Length; i++)
        {
            tab[i] = tab[i-1] + tab[i-2];
        }

        Afficher(tab);
    }

    //Fonction qui affiche un tableau
    static void Afficher(int[] tab)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            Console.Write($"{tab[i]} ");
        }
        Console.WriteLine();
    }
}