using System;

class Exo2
{

    static void Main()
    {   
        const int TAILLE = 10;

        //declaration des tableaux
        int [] tab1 = new int[TAILLE];
        int [] tab2 = new int[TAILLE];
        int [] tab3 = new int[TAILLE];

        //remplissage des tableaux
        for (int i = 0; i < TAILLE; i++)
        {
            tab1[i] = 0;
            tab2[i] = i + 1;
            tab3[i] = 20 - 2 * i;
        }

        Afficher(tab1);
        Afficher(tab2);
        Afficher(tab3);
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