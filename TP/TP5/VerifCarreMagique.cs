using System;

class VerifCarreMagique
{

    static void Main()
    {
        int[,] tab = { { 1, 12, 7, 14 },
                       { 8, 13, 2, 11 },
                       { 10, 3, 16, 5 },
                       { 15, 6, 9, 40 }};

        bool flag = IsCarreMagique(tab);
        Console.WriteLine(flag);
    }

    static bool IsCarreMagique(int[,] tab)
    {
        int somme = SommeDiago1(tab);

        if (SommeDiago2(tab) != somme)
        {
            return false;
        }

        for (int i = 0; i < tab.GetLength(0); i++)
        {
            if (SommeLigne(tab, i) != somme)
            {
                return false;
            }
        }

        for (int i = 0; i < tab.GetLength(1); i++)
        {
            if (SommeColonne(tab, i) != somme)
            {
                return false;
            }
        }

        return true;

    }

    static int SommeLigne(int[,] tab, int ligne)
    {
        int somme = 0;

        for (int i = 0; i < tab.GetLength(1); i++)
        {
            somme += tab[ligne, i];       
        }

        return somme;
    }

    static int SommeColonne(int[,] tab, int colonne)
    {
        int somme = 0;

        for (int i = 0; i < tab.GetLength(0); i++)
        {
            somme += tab[i, colonne];
        }

        return somme;
    }

    static int SommeDiago1(int[,] tab)
    {
        int somme = 0;

        for (int i = 0; i < tab.GetLength(1); i++)
        {
            somme += tab[i, i];
        }

        return somme;

    }

    static int SommeDiago2(int[,] tab)
    {
        int somme = 0;

        for (int i = 0; i < tab.GetLength(1); i++)
        {
            somme += tab[i, tab.GetLength(1) - 1 - i];
        }

        return somme;
    }
}