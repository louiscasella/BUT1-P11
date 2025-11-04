using System;

class DevineNombre
{

    static void Main()
    {

        //initialisation nombre random
        int nombreRandom;
        Random rnd = new Random();
        nombreRandom = rnd.Next(1,100);

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
            Console.WriteLine($"Bravo, trouvé en {i-1} coups !");
        }

    }

}