using System;

class TriangleIsocele
{

    static void Main()
    {

        //declaration des variables 
        int nbEtoile = 1;
        int hauteur, nbEspace;

        //debut
        Console.WriteLine("Donner hauteur du triangle : ");
        hauteur = int.Parse(Console.ReadLine());

        nbEspace = hauteur - nbEtoile;

        //Affichage du Triangle
        for (int i = 1; i <= hauteur; i++)
        {
            
            for (int j = 1; j <= nbEspace; j++)
            {
                Console.Write(" ");
            }

            for (int h = 1; h <= nbEtoile; h++)
            {
                Console.Write('*');
            }

            Console.WriteLine();
            nbEtoile +=2;
            nbEspace --;

        }

    }

}