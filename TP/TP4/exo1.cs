using System;

class Exo1
{
    static void Main()
    {

        double[] lesNotes = {10,12.5,11,10,6.5,9.5,15,10,15,14,17,2};

        Afficher(lesNotes);          // 1.

        PlusPetite(lesNotes);        // 2.

        AfficherInverse(lesNotes);   // 3.

        SommeSup10(lesNotes);        // 4.

        FirstIndice6(lesNotes);      // 5.
        
        LastIndice10(lesNotes);      // 6.
        
        Is20inTab(lesNotes);         // 7.

        Occurence(lesNotes);         // 8.


    }

    //Fonction qui affiche le tableau dans l'ordre
    static void Afficher(double[] tab)
    {
        for(int i = 0; i < tab.Length; i++)
        {
            Console.Write(tab[i] + " ");
        }
        
        Console.WriteLine();
        Console.WriteLine();
    }

    //Fonction qui affiche la valeur minimum du tableau
    static void PlusPetite(double[] tab)
    {
        double min = tab[0];
        
        for(int i = 0; i < tab.Length; i++)
        {
            if (tab[i] < min)
            {
                min = tab[i];
            }
        }

        Console.WriteLine($"la note minimum est : {min}");
        Console.WriteLine();
    }

    //Fonction qui affiche le tableau dans l'ordre inverse
    static void AfficherInverse(double[] tab)
    {
        for(int i = tab.Length-1; i >= 0; i--)
        {
            Console.Write(tab[i] + " ");
        }
        
        Console.WriteLine();
        Console.WriteLine();
    }

    //Fonction qui affiche la somme des notes supérieures à 10
    static void SommeSup10(double[] tab)
    {
        double somme = 0;
        int nbSomme = 0;

        for(int i = 0; i < tab.Length; i++)
        {
            if (tab[i] > 10)
            {
                somme += tab[i];
                nbSomme ++;
            }
        }

        if (nbSomme > 0)
        {
            Console.WriteLine($"Il y a {nbSomme} notes au dessus de 10, leur moyenne est de {somme/nbSomme}");
        }

        else
        {
            Console.WriteLine("Aucune note au dessus de 10 (t'es éteint)");
        }

        Console.WriteLine();
    }

    //Fonction qui affiche l'indice du premier 6 dans le tableau 
    //(version de la prof avec test du 6 dans le while)
    static void FirstIndice6(double[] tab)
    {
        int i = 0;

        while (i < tab.Length && tab[i] != 6)
        {
            i++;
        }

        if (i < tab.Length)
        {
            Console.WriteLine($"l'indice du premier 6 est {i}");
        }

        else
        {
            Console.WriteLine("Pas de 6");
        }

        Console.WriteLine();
    }

    //Fonction qui affiche l'indice du dernier 10 dans le tableau 
    //(version que j'avais faite en TD, plus long mais plus simple dans les < ou <= ...)
    static void LastIndice10(double[] tab)
    {
        int i = tab.Length - 1;
        int indice = -1;

        while (i >= 0 && indice < 0)
        {
            if (tab[i] == 10)
            {
                indice = i;
            }

            i--;
        }

        if (indice < 0)
        {
            Console.WriteLine("Pas de 10");
        }

        else
        {
            Console.WriteLine($"L'indice du dernier 10 est : {indice}");
        }

        Console.WriteLine();
    }

    //Fonction qui affiche si il y a un 20 ou non dans le tableau, avec un booleen
    static void Is20inTab(double[] tab)
    {
        bool flag = false;
        int i = 0;

        while (i < tab.Length && flag == false)
        {
            if (tab[i] == 20)
            {
                flag = true;
            }

            i++;
        }

        Console.WriteLine($"Présence d'un 20 dans le tableau : {flag}");
        Console.WriteLine();
    }

    //Fonction qui affiche l'occurence d'un nombre entrer par l'utilisateur dans le tableau
    static void Occurence(double[] tab)
    {
        int occurence = 0;

        Console.WriteLine("Saisir l'entier à compter : ");
        int nb = int.Parse(Console.ReadLine());

        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i] == nb)
            {
                occurence ++;
            }
        }

        Console.WriteLine($"Il y a {occurence} occurence(s) de {nb} dans le tableau !");
    }
}