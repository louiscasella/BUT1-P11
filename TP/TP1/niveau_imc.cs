using System;
class CalculeIMC
{
    static void Main()
    {

        //declaration variable
        double taille;
        double poids;
        double imc;

        //saisie
        Console.WriteLine("donnez taille en metre");
        taille = double.Parse(Console.ReadLine());
        Console.WriteLine("donnez poids en kg");
        poids = double.Parse(Console.ReadLine());

        //Calcules
        imc = poids / (taille * taille);

        //verification
        if (taille > 1.50 && taille < 2.10)
        {
        
            Console.WriteLine($"Votre IMC est de : {imc} !");


            if (imc < 16.5)
            {
                Console.WriteLine("Votre niveau est : -2 (insuffisance sévère)");
            }

            else if (imc <= 18.5)
            {
                Console.WriteLine("Votre niveau est : -1 (insuffisance pondérale)");
            }

            else if (imc <= 25)
            {
                Console.WriteLine("Votre niveau est : 0 (corpulence normale)");
            }

            else if (imc <= 30)
            {
                Console.WriteLine("Votre niveau est : 1 (surpoids)");
            }

            else if (imc <= 35)
            {
                Console.WriteLine("Votre niveau est : 2 (obésité modérée)");
            }

            else if (imc <= 40)
            {
                Console.WriteLine("Votre niveau est : 3 (obésité sévère)");
            }

            else
            {
                Console.WriteLine("Votre niveau est : 4 (obésité massive)");
            }

        }

        else
        {
            Console.WriteLine("/!\\ Erreur : la taille doit etre comprise entre 1.50m et 2.10m");
        }

    }
}





/*      NE MARCHE PAS

        switch (imc)
        {
            case < 16.5:
                Console.WriteLine("Votre niveau est : -2 (insuffisance sévère)");
                break;

            case <= 18.5:
                Console.WriteLine("Votre niveau est : -1 (insuffisance pondérale)");
                break;

            case <= 25:
                Console.WriteLine("Votre niveau est : 0 (corpulence normale)");
                break;

            case <= 30:
                Console.WriteLine("Votre niveau est : 1 (surpoids)");
                break;

            case <= 35:
                Console.WriteLine("Votre niveau est : 2 (obésité modérée)");
                break;

            case <= 40:
                Console.WriteLine("Votre niveau est : 3 (obésité sévère)");
                break;

            case > 40:
                Console.WriteLine("Votre niveau est : 4 (obésité massive)");
                break;
            
            default:
                Console.WriteLine("Erreur");
                break;*/