using System;

class CarreMagique
{
    static void Main()
    {
            
        Console.WriteLine("Donner taille (impair) du carré magique");
        int taille = int.Parse(Console.ReadLine());

        int[,] tab = new int[taille, taille];

        int ligne = taille / 2 - 1;
        int colonne = taille / 2 + 1;

        int valMax = taille * taille;

        tab[ligne, colonne] = 1;

        for (int i = 2; i <= valMax; i++)
        {   
            Console.WriteLine(i);
            
            if (ligne == 0 && colonne == taille - 1)  // CAS DIAGONAL
            {
                ligne = FindLastEmpty(tab, taille);
            }

            if (ligne == 0)  // CAS OU ARRIVE EN HAUT
            {
                ligne = taille - 1;
            }
            if (colonne == taille - 1) // CAS OU ARRIVE A DROITE
            {
                colonne = 0;
            }

            if (tab[ligne - 1, colonne + 1] != 0)  // CAS OU EN HAUT A DROITE N'EST PAS VIDE
            {
                ligne--;
                colonne--;
            }

            // CAS DE BASE
            
            tab[ligne,colonne] = i;
            ligne--;
            colonne++;

            
        }

        Afficher(tab);

    }

    static int FindLastEmpty(int[,] tab, int taille)
    {
        int ligne = taille - 1;
        while (tab[ligne, taille - 1] != 0)
        {
            ligne--;
        }

        return ligne;
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
}
