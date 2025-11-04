using System;

class NbMin
{

    static void Main()
    {
        
        //initialisation variables
        int nbmin, nb;

        //demander la saisie du premier entier et initalise nbmin comme le premier entier
        Console.WriteLine("Saisir entier numéro 1 : ");
        nb = int.Parse(Console.ReadLine());
        nbmin = nb;

        //boucle et calcules
        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine($"Saisir entier numéro {i} : ");
            nb = int.Parse(Console.ReadLine());

            if (nb < nbmin)
            {
                nbmin = nb;
            }
        }

        Console.WriteLine($"\nVotre nombre minimum est : {nbmin}");

    }
}