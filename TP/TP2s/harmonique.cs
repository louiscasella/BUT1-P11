using System;

class Harmonique
{
    static void Main()
    {
        Console.WriteLine("Donner la suite harmonique de : ");
        int n = int.Parse(Console.ReadLine());

        double somme = 0;

        for (int i = 1; i <= n; i++)
        {
            somme += (1.0 / i);
        }

        Console.WriteLine(somme);

    }
}
