using System;

class ConvertBinary
{
    static void Main()
    {
        int[] tab = new int[8];

        
        //saisie blindée pour verifier que le nb est entre 0 et 255
        int nb;

        do 
        {
            Console.WriteLine("Entrer nombre à convertir en binaire : (0-255)");
            nb = int.Parse(Console.ReadLine());
        }
        while (nb < 0 || nb > 255);

        //remplissage tableau
        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = nb % 2;
            nb /= 2;
        }

        AfficherInverse(tab);

    }

    //Fonction qui affiche le tableau dans l'ordre inverse
    static void AfficherInverse(int[] tab)
    {
        for(int i = tab.Length-1; i >= 0; i--)
        {
            Console.Write(tab[i]);
        }

        Console.WriteLine();
    }
}