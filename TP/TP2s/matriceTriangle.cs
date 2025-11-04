using System;

class MatriceTriangle
{
    static void Main()
    {   

        //initialisation de la hauteur de la matrice
        Console.WriteLine("Donner hauteur de la matrice : ");
        int hauteur = int.Parse(Console.ReadLine());

        //Affichage de la premiere ligne (une ligne de 1)
        for (int k = 1; k <= hauteur; k++)
        {
            Console.Write("1  ");
        }
        Console.WriteLine();

        //demarage de l'affichage
        for (int i = 1; i <= hauteur - 1; i++)
        {   

            //affichage des zeros, boucle iterative croissante
            for (int h = 1; h <= i; h++)
            {
                Console.Write("0  ");
            }

            //affichage des uns, boucle iterative descroissante
            for (int j = hauteur - 1; j >= i; j--)
            {
                Console.Write("1  ");
            }
            Console.WriteLine();
        }
    }
}