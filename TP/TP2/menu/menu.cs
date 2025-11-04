using System;

class Menu
{

    static void Main()
    {
        Console.WriteLine("Choisir un exo : (1-11)");

        Console.WriteLine("1: Nombre de 7 à 77");
        Console.WriteLine("2 : Triangle Rectangle");
        Console.WriteLine("3 : Triangle Isocele");
        Console.WriteLine("4 : Table  de Multiplication");
        Console.WriteLine("5 : Nombre min");
        Console.WriteLine("6 : Somme");
        Console.WriteLine("7 : Factoriel");
        Console.WriteLine("8 : Devine nombre");
        Console.WriteLine("9 : Armstrong");
        Console.WriteLine("10 : Compte A");
        Console.WriteLine("11 : nombre Premier");

        int exo = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine($"vous avez choisi l'exercice : {exo}");
        Console.WriteLine();


        switch (exo)
        {
            case 1:
                SevenToSeventySeven();
                break;
            case 2:
                TriangleRectangle();
                break;
            case 3:
                TriangleIsocele();
                break;
            case 4:
                TableMult();
                break;
            case 5:
                NombreMin();
                break;
            case 6:
                Somme();
                break;
            case 7:
                Facto();
                break;
            case 8:
                DevineNombre();
                break;
            case 9:
                Armstrong();
                break;
            case 10:
                CompteA();
                break;
            case 11:
                NombrePremier();
                break;
        }

        


    }

    static void SevenToSeventySeven()
    {
        //boucle iterative Pour
        Console.WriteLine("Boucle For :");

        for (int i = 7; i <= 77; i++)
        {
            Console.Write(i + " ");
        }

        //boucle iterative TantQue
        Console.WriteLine("\nBoucle While :");

        int j = 7;

        while (j <= 77)
        {
            Console.Write(j + " ");
            j++;
        }

        //boucle iterative Do
        Console.WriteLine("\nBoucle Do :");

        int k = 7;

        do
        {
            Console.Write(k + " ");
            k++;
        } while (k <= 77);

        Console.WriteLine();
    }

    static void TriangleRectangle()
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

    static void TriangleIsocele()
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
            nbEtoile += 2;
            nbEspace--;
        }
    }

    static void TableMult()
    {
        //declaration des variables
        Console.WriteLine("Rentrer numéro de la table de multiplication : ");
        int table = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{i} x {table} = {i * table}");
        }
    }

    static void NombreMin()
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

    static void Somme()
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

    static void Facto()
    {
        //decla variable
        int mult = 1;

        Console.WriteLine("donner nombre : ");
        int facto = int.Parse(Console.ReadLine());

        //verif que facto est bien superieur a 0, sinon relance l'entrée clavier
        while (facto < 0)
        {
            Console.WriteLine("donner nombre : (positif!)");
            facto = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= facto; i++)
        {
            mult *= i;
        }

        Console.WriteLine($"Factorielle de {facto} = {mult}");
    }

    static void DevineNombre()
    {
        //initialisation nombre random
        int nombreRandom;
        Random rnd = new Random();
        nombreRandom = rnd.Next(1, 100);

        //inititalisation guessNb
        Console.WriteLine("Deviner nombre entre 1 et 100 : (essai numéro 1)");
        int guessNb = int.Parse(Console.ReadLine());

        int i = 2;

        //cas ou guessNb n'est pas le nombre random et le nombre d'essais est inferieur a 10
        while (guessNb != nombreRandom && i < 10)
        {

            //cas ou guessNb est inferieur
            if (guessNb < nombreRandom)
            {
                Console.WriteLine("Trop petit !");
                Console.WriteLine($"Deviner nombre entre 1 et 100 : (essai numéro {i})");
                guessNb = int.Parse(Console.ReadLine());
            }

            //cas ou guessNb est superieur
            else
            {
                Console.WriteLine("Trop grand !");
                Console.WriteLine($"Deviner nombre entre 1 et 100 : (essai numéro {i})");
                guessNb = int.Parse(Console.ReadLine());
            }

            i++;
        }

        //cas ou on sort de la boucle car atteint les 10 essais
        if (i == 10)
        {
            Console.WriteLine($"Dommage le nombre était : {nombreRandom}");
        }

        //cas ou on sort de la boucle car nombre trouvé
        else
        {
            Console.WriteLine($"Bravo, trouvé en {i - 1} coups !");
        }
    }

    static void Armstrong()
    {
        //decla constante
        int BORNE_MIN = 2;
        int BORN_MAX = 999;
        int NB_ARMSTRONG = 4;

        //decla variables
        int c, d, u, n, temp, nbA;

        //debut
        n = BORNE_MIN;
        nbA = 0;

        while (n <= BORN_MAX && nbA < NB_ARMSTRONG)
        {
            c = n / 100;
            temp = n % 100;
            d = temp / 10;
            u = temp % 10;

            if (c * c * c + d * d * d + u * u * u == n)
            {
                Console.WriteLine(n);
                nbA++;
            }

            n++;
        }
    }

    static void CompteA()
    {
        //definition variable
        int somme = 0;
        char caract = ' ';
        int i = 0;

        while (caract != '*')
        {
            Console.WriteLine("Saisir un caractere :");
            caract = char.Parse(Console.ReadLine());

            if (caract == 'A' || caract == 'a')
            {
                somme++;
            }

            i++;
        }

        Console.WriteLine($"Vous avez saisi {i - 1} caracteres, \ndont {somme} 'A' ou 'a' \nCe qui fait une fréquence de : {(float)somme / (i - 1)}");
    }

    static void NombrePremier()
    {
        bool isFirst = true;
        int i = 2;

        Console.WriteLine("Saisir un entier : ");
        int n = int.Parse(Console.ReadLine());

        while (i < n && isFirst)
        {
            if (n % i == 0)
            {
                isFirst = false;
            }

            i++;
        }

        if (isFirst)
        {
            Console.WriteLine($"{n} est premier !");
        }
        else
        {
            Console.WriteLine($"{n} n'est pas premier !");   
        }   
    }

}