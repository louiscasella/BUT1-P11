using System;

class TriangleRectangle
{

    static void Main()
    {

        //decla variables
        int hauteur;
        int nbEtoile = 1;

        Console.WriteLine("Donner hauteur du triangle : ");
        hauteur = int.Parse(Console.ReadLine());

        //boucles iteratives imbriquées
        for (int i = 1; i <= hauteur; i++)
        {
            for (int j = 1; j <= nbEtoile; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
            Console.WriteLine();
            nbEtoile += 2;
        }

    }

}