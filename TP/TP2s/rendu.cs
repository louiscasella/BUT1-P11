using System;

class Rendu
{
    static void Main()
    {
        //decla variables
        int cafe = 40;
        int piece;
        bool rendu = false;


        while (rendu == false)
        {
            Console.WriteLine("Inserer le montant de la piece :");
            piece = int.Parse(Console.ReadLine());

            if (cafe > 0)
            {
                if (piece == 10 || piece == 20 || piece == 50 || piece == 100)
                {
                    cafe -= piece;
                }

                else
                {
                    Console.WriteLine("Piece de 10cts minimum");
                }
            }

            else
            {
                rendu = true;
            }
        }

        Console.WriteLine("Merci");

    }
}