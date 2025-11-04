using System;

class TriBulle
{
    static void Main()
    {

        int[] tableau = {20,10,0,1,3,4,5};

        TriBulles(tableau);
        Afficher(tableau);
    }

    static void TriBulles(int[] tab)
    {   
        int temp;

        for (int i = tab.Length - 1; i >= 1; i--)
        {
            for (int j = 0; j <= i - 1; j++)
            {
                if (tab[j+1] < tab[j])
                {
                    temp = tab[j];
                    tab[j] = tab[j+1];
                    tab[j+1] = temp;
                }
            }
        }
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