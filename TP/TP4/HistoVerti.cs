using System;

class HistoVerti
{
    static void Main()
    {   
        //initialisation du tableau
        int[] histogramme = {2,1,3,6,7,10,3,1,1,1,14,8,9,0,0,3,3,4,7,0,6};
        //new int[21];

        //Saisie blindée pour rentrer les nombres jusqu'à -1
        /* int nb;

        do
        {   
            Console.WriteLine("Entrer nombre (0-20) : ");
            nb = int.Parse(Console.ReadLine());

            if (nb != -1)
            {
                histogramme[nb]++;
            }
        }
        while (nb >= 0 && nb <= 20);
        */

        //Affichage du tableau
        Console.Write("Tableau : ");
        Afficher(histogramme);

        //Affichage de l'histogramme
        Histogramme(histogramme);
        
    }

    //Affichage de l'histogramme
    static void Histogramme(int[] tab)
    {   

        int max = PlusGrande(tab);

        for (int i = max; i >= 1; i--)
        {
            for (int j = 0; j < tab.Length; j++)
            {
                if (tab[j] >= i)
                {
                    Console.Write("  ◼︎   ");
                }

                else
                {
                    Console.Write("      ");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("  0  |  1  |  2  |  3  |  4  |  5  |  6  |  7  |  8  |  9  |  10 |  11 |  12 |  13 |  14 |  15 |  16 |  17 |  18 |  19 |  20");
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

    static int PlusGrande(int[] tab)
    {
        int max = tab[0];
        
        for(int i = 0; i < tab.Length; i++)
        {
            if (tab[i] > max)
            {
                max = tab[i];
            }
        }

        return max;
    }

}