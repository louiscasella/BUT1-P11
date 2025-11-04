using System;
class Pascal
{

    static void Main()
    {
        Console.WriteLine("Donner hauteur du triangle : ");
        int n = int.Parse(Console.ReadLine());

        int[,] tab = CreatePascalTriangle(n);

        Afficher(tab);

    }

    static int[,] CreatePascalTriangle(int n)
    {

        int[,] tab = new int[n, n];

        for (int i = 0; i < tab.GetLength(0); i++)
        {
            tab[0, i] = 0;
        }

        for (int i = 0; i < tab.GetLength(1); i++)
        {
            tab[i, 0] = 1;
        }


        for (int i = 1; i < tab.GetLength(0); i++)
        {
            for (int j = 1; j < tab.GetLength(1); j++)
            {
                tab[i, j] = tab[i - 1, j] + tab[i - 1, j - 1];
            }
        }

        return tab;
    }
    
    static void Afficher(int[,] tab)
    {
        int padMax = 0;
        for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int j = 0; j < tab.GetLength(1); j++)
            {
                if (tab[i, j] > padMax)
                {
                    padMax = tab[i, j];
                }
            }
        }

        padMax = padMax.ToString().Length + 1;  //  /!\ Nombre de chiffres dans un nombre
        
        for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int j = 0; j < tab.GetLength(1); j++)
            {
                if (tab[i, j] == 0)
                {
                    Console.Write(" ".PadLeft(padMax));
                }
                else
                {
                    Console.Write($"{tab[i, j]}".PadLeft(padMax));
                }
            }
            
            Console.WriteLine();
        }
    }
}