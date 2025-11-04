using System;

class Prime
{

    static void Main()
    {

        //decla variables
        int s, m, t, matricule;
        double prime, sommePrime = 0;
        int sommeT = 0;

        Console.WriteLine("Saisir nombre d'employés");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Saisir le matricule de l'employé {i} :");
            matricule = int.Parse(Console.ReadLine());

            Console.WriteLine($"Saisir salaire de l'employé {i}:");
            s = int.Parse(Console.ReadLine());

            Console.WriteLine($"Saisir nb de mois de travail de l'employé {i} :");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine($"Saisir nb jours d'arret de l'employé {i} :");
            t = int.Parse(Console.ReadLine());

            //calcule

            prime = ((s * m) / 12);

            if (t < 3)
            {
                prime *= 2;
            }
            else if (t >= 3 && t <= 10)
            {
                prime *= 0.5;
            }
            else
            {
                prime *= 0.25;
            }

            Console.WriteLine($"Matricule : {matricule}\nsalaire : {s}\nnombre de mois travaillés : {m}\nnombre de jour d'arrets de travail: {t}\nprime : {prime}\n");

            sommePrime += prime;
            sommeT += t;
        }

        Console.WriteLine($"Total des primes : {sommePrime}\nTotal jours d'arrets : {sommeT}\nNb moyen de jours d'arrets par empl : {sommeT / n}");


    }

}