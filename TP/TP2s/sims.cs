using System;

class Sims
{

    static void Main()
    {

        //decla variables
        double simsA = 10000000, simsB = 500000;
        int annee = 0;
        while (simsB <= simsA)
        {   
            annee++;
            simsA += 500000;
            simsB *= 1.03;
        }

        Console.WriteLine($"La population de simsB à depassée celle des simsA en {annee} ans");

    }

}