using System;

class Loto
{
    static void Main()
    {

        int[,] loto = {
            {18,21,26,44,47,3},{5,10,15,43,45,9},{6,8,31,36,45,9},{2,13,24,39,48,1},{13,28,37,
            45,48,9},{7,8,22,28,38,10},{3,21,32,33,38,10},{4,7,14,31,37,8},{6,20,24,31,36,4},{4
            ,14,23,35,46,7},{19,31,38,44,49,3},{18,21,32,33,41,9},{5,17,23,43,49,4},{2,10,13,35,40,1},
            {1,2,27,31,45,8},{11,18,24,41,48,2},{23,34,36,39,49,8},{22,23,26,29,40,5},{
            8,15,24,39,48,8},{1,3,7,14,38,5},{6,11,12,19,45,10},{7,13,24,36,42,4},{5,16,18,34,
            37,5},{7,13,30,44,48,7},{1,18,29,39,40,2},{21,28,39,46,49,1},{2,34,41,44,46,2},{9,21,42,43,46,6},
            {8,9,28,35,42,6},{25,29,34,44,47,9},{2,15,28,36,49,3},{1,9,18,24,46,
            7},{1,4,15,18,38,6},{6,8,16,32,37,7},{1,13,36,44,48,2},{10,11,23,43,49,10},{5,9,18,
            26,36,9},{2,17,23,25,37,7},{8,11,19,48,49,7},{9,25,34,38,49,1},{4,7,24,29,46,10},{3
            ,17,27,34,41,4},{1,9,24,26,35,4},{2,17,22,38,44,8},{9,16,24,32,42,3},{2,9,12,21,29,
            7},{4,11,31,36,46,10},{13,22,33,36,49,4},{2,11,28,33,43,1},{17,18,21,36,47,6},{20,
            35,39,42,48,2},{5,32,33,46,49,1},{21,26,33,46,49,1},{3,6,22,35,47,1},{3,8,12,29,35
            ,1},{2,17,40,46,48,10},{12,17,24,30,38,7},{9,26,27,29,36,5},{9,27,31,32,44,8},{14,22,23,27,28,4},
            {4,10,33,35,41,5},{1,16,29,31,39,2},{4,10,18,27,30,1},{8,11,12,26,48
            ,6},{3,6,28,39,42,5},{14,17,18,28,44,2},{12,19,41,42,49,8},{7,11,16,37,47,10},{1,16
            ,27,35,41,1},{24,35,37,45,48,2},{19,21,23,36,49,4},{3,9,15,40,48,10},{15,23,45,48,
            49,2},{15,24,30,43,48,7},{14,20,24,44,48,10},{26,28,29,42,48,1},{22,31,37,43,45,5
            },{11,14,17,23,43,10},{2,8,25,28,44,4},{7,10,25,37,47,10},{4,23,37,42,43,7},{7,16,18,33,43,5},{3,9,21,43,45,1},
            {10,16,24,27,47,5},{20,22,28,32,47,6},{5,11,26,30,48,1
            },{11,15,24,38,47,6},{12,27,30,32,42,7},{20,26,31,47,49,10},{22,31,33,39,43,10},{2
            ,10,28,33,46,8},{3,16,22,28,49,4},{13,16,18,19,20,2},{19,23,36,39,49,3},{9,16,28,41,49,5},{8,14,29,44,48,7},
            {23,27,43,46,49,6},{13,22,28,31,40,9},{9,11,21,27,49,5},{
            5,7,8,22,26,2},{7,8,15,18,25,6},{5,6,27,43,46,7},{8,9,22,32,46,8},{16,32,37,38,44,3
            },{25,26,32,33,41,3},{1,15,22,23,46,9},{5,12,21,29,42,2},{2,14,17,37,38,1},{1,17,25
            ,37,45,9},{1,7,11,33,43,1},{1,8,30,38,40,6},{8,25,33,39,43,8},{7,13,36,41,45,5},{13,
            21,24,44,47,3},{17,19,22,29,43,8},{9,11,15,42,49,3},{16,20,21,33,39,2},{4,14,22,35,38,5},
            {3,13,15,32,46,5},{4,10,36,40,41,10},{9,14,16,47,49,7},{11,13,18,24,33,7},{
            1,26,29,31,38,5},{1,13,22,37,46,9},{9,22,25,33,44,3},{1,4,9,20,35,8},{2,17,23,26,43,3},
            {6,25,33,37,43,1},{7,9,29,31,46,8},{7,13,16,35,41,1},{15,16,23,30,41,8},{9,10,
            15,43,44,5},{14,20,22,32,47,5},{4,17,21,23,26,2},{1,11,12,27,29,2},{4,9,30,38,46,10},
            {14,17,20,33,47,1},{5,17,25,29,38,2},{16,20,39,47,48,4},{6,9,14,35,47,9},{7,19,24,35,42,3},
            {6,15,33,46,49,1},{1,15,17,24,28,10},{11,15,29,46,47,3},{13,30,39,42,44,9},{7,10,16,29,30,5},
            {1,8,18,29,36,9},{6,9,13,23,32,4},{11,22,35,40,41,7},{4,6,16,
            28,37,8},{6,9,14,40,49,3},{3,9,11,28,38,1},{4,15,19,24,44,1},{13,25,30,33,36,9},{7,
            12,15,24,33,6},{14,31,32,34,46,3 }
        };

        int choix;

        do //saisie blindée pour le menu
        {
            Console.WriteLine("Veuillez Choisir entre : ");
            Console.WriteLine("(1) Afficher Tirage pour une semaine et un numéro de tirage donné.");
            Console.WriteLine("(2) Afficher tous les tirages de l'année.");
            Console.WriteLine("(3) Afficher tous les numéros chance de l'année.");
            Console.WriteLine("(4) Afficher la fréquence des numéros tirés (non chance). /!\\ Il faut dezoomer dans le terminal pour avoir un rendu joli ! (sinon c moche)");
            Console.WriteLine("(5) Afficher la fréquence des numéros chance.");
            Console.WriteLine("(6) Afficher fréquence et pourcentage d'un tableau de fréquence. (decroissant)");

            choix = int.Parse(Console.ReadLine());
        } while (choix < 1 || choix > 6);

        switch (choix)
        {
            case 1:

                Console.WriteLine();
                Console.WriteLine("Donner numero de semaine (0-52) : ");
                int nSemaine = int.Parse(Console.ReadLine());

                Console.WriteLine("Donner numero de tirage (1-3) : ");
                int nTirage = int.Parse(Console.ReadLine());

                if (nSemaine < 0 || nSemaine > 52 || nTirage < 1 || nTirage > 3)
                {
                    Console.WriteLine("Mauvaise saisie, la semaine doit etre comprise entre 0 et 52 et le numero de tirage entre 1 et 3 !!");
                }

                else
                {
                    afficherTirage(loto, nSemaine, nTirage);
                }

                break;

            case 2:

                Console.WriteLine();
                afficherAllTirage(loto);
                break;

            case 3:

                Console.WriteLine();
                afficherNbChance(loto);
                break;

            case 4:

                Console.WriteLine();
                int[] freq1 = freqNum(loto);
                afficherTabFrequence(freq1);
                break;

            case 5:

                Console.WriteLine();
                int[] freq2 = freqNumChance(loto);
                afficherTabFrequence(freq2);
                break;

            case 6:  //J'ai fais le choix d'afficher le tableau des numéros chances, celui des numeros tirés est trop long...

                Console.WriteLine();
                int[] freq = freqNumChance(loto);
                int[,] freqDecroi = freqDecroissantes(freq);

                afficherFrequenceDecroi(freqDecroi);
                break;
        }


    }

    //procedure qui affiche les 5 numéros et le numero chance pour une semaine et un numero de tirage donnée
    static void afficherTirage(int[,] loto, int nSemaine, int nTirage)
    {
        int LigneTirage = (nSemaine - 1) * 3 + (nTirage - 1); //La ligne a afficher est trouvée avec cette formule

        for (int i = 0; i < loto.GetLength(1) - 1; i++)
        {
            Console.Write(loto[LigneTirage, i] + " - ");
        }
        Console.WriteLine($"numero chance : {loto[LigneTirage, loto.GetLength(1) - 1]}");
    }

    //procedure qui affiche tous les tirages de l'année
    static void afficherAllTirage(int[,] loto)
    {
        for (int i = 1; i <= 52; i++)
        {
            Console.WriteLine($"Semaine {i} ");
            for (int j = 1; j <= 3; j++)
            {
                Console.Write($"tirage {j}: ");
                afficherTirage(loto, i, j);
            }
        }
    }

    //procedure qui affiche tous les numeros chances de l'année
    static void afficherNbChance(int[,] loto)
    {
        for (int i = 1; i <= 52; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                int LigneTirage = (i - 1) * 3 + (j - 1); //meme formule pour trouver la ligne
                Console.Write(loto[LigneTirage, loto.GetLength(1) - 1] + " ");
            }
            Console.WriteLine();
        }
    }

    //fonction qui renvoie un tableau des fréquences des numero tirés
    static int[] freqNum(int[,] loto)
    {
        int[] freq1 = new int[50];

        for (int i = 0; i < loto.GetLength(0); i++)
        {
            for (int j = 0; j < loto.GetLength(1) - 1; j++)
            {
                freq1[loto[i, j]]++;
            }
        }

        return freq1;
    }

    //fonction qui renvoie un tableau des fréquences des numero chances tirés
    static int[] freqNumChance(int[,] loto)
    {
        int[] freq2 = new int[11];

        for (int i = 0; i < loto.GetLength(0); i++)
        {
            freq2[loto[i, loto.GetLength(1) - 1]]++;
        }

        return freq2;
    }

    //procedure qui gere l'affichage de ces tableaux (pour que ce soit tout joli !)
    static void afficherTabFrequence(int[] tab)
    {
        Console.Write("Nombre    | ");
        for (int i = 1; i < tab.Length; i++)
        {
            Console.Write($"{i}".PadRight(2)); //utilisation de la fonction PadRight/Left que Monsieur Perrin m'a expliqué. Merci à vous ma vie est tellement mieux depuis
            Console.Write(" | ");
        }
        Console.WriteLine();

        Console.Write("Frequence | ");
        for (int i = 1; i < tab.Length; i++)
        {
            Console.Write($"{tab[i]}".PadRight(2));
            Console.Write(" | ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    //fonction qui renvoie un tableau 2D de 2 ligne
    //sur la premiere les numeros sortis
    //sur la deuxieme leur frequence
    //tout ca trié en decroissant à l'aide d'un tri à bulle
    static int[,] freqDecroissantes(int[] tab)
    {

        int[,] freqDecroi = new int[2, tab.Length];

        for (int i = 0; i < tab.Length; i++)
        {
            freqDecroi[0, i] = i;
            freqDecroi[1, i] = tab[i];
        }

        int tempVal, tempIndex;


        //tri a bulle qui gere les deux lignes a la fois, indice et valeur
        for (int i = 0; i < tab.Length - 1; i++)
        {
            for (int j = 0; j < tab.Length - i - 1; j++)
            {
                if (freqDecroi[1, j] < freqDecroi[1, j + 1])
                {

                    tempVal = freqDecroi[1, j];
                    freqDecroi[1, j] = freqDecroi[1, j + 1];
                    freqDecroi[1, j + 1] = tempVal;

                    tempIndex = freqDecroi[0, j];
                    freqDecroi[0, j] = freqDecroi[0, j + 1];
                    freqDecroi[0, j + 1] = tempIndex;
                }
            }
        }

        return freqDecroi;
    }


    //procedure qui affiche les frequences du tableau ci dessus, avec un pourcentage de présence.
    static void afficherFrequenceDecroi(int[,] tab)
    {

        int sommeFrequence = 0;

        for (int i = 0; i < tab.GetLength(1); i++)
        {
            sommeFrequence += tab[1, i];
        }
        
        for (int i = 0; i < tab.GetLength(1) - 1; i++)
        {
            double pourcentage = (double)tab[1, i] / sommeFrequence * 100;  //passage de la valeur entiere en double pour faire une division
            Console.WriteLine($"{tab[0, i]} ({pourcentage.ToString("F2")}%)"); //Fonction ToString pour passer la valeur en chaine de caractere puis "F2" pour la tronquer à 2 chiffres apres la virgule !!
        }
    }
    
}