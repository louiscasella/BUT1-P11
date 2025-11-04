using System;

class Exo6
{

    static void Main()
    {

        int[] tab = new int[10];


    }

    static int RechercheIndiceInsertion(int[] tab)
    {
        Console.WriteLine("Entrer valeur à inserer : ");
        int val = int.Parse(Console.ReadLine());

        int indice = 0;
        int nbVal = 0;
 
        for (int i = 0; i < nbVal && tab[i] < val; i++)
        {
            indice++;
        }
    }


}