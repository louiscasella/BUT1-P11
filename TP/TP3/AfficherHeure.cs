using System;

class exo1
{

    static void Main()
    {
        
        Console.WriteLine("Rentrer un nombre de minutes");
        int m = int.Parse(Console.ReadLine());

        AfficherHeure(m);
    }

    static void AfficherHeure(int m)
    {
        int heure = m / 60;
        int minute = m % 60;

        Console.WriteLine($"{heure:D2}:{minute}");
    }
}