using System;

class Somme
{

    static void Main()
    {

        //declaration variables

        int nb, somme = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Saisir entier numéro {i} : ");
            nb = int.Parse(Console.ReadLine());

            somme += nb;
        }

        Console.WriteLine($"La somme de vos nombre est : {somme}");

    }

}