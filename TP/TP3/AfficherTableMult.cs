using System;

class exo2
{

    static void Main()
    {
        
        Console.WriteLine("Rentrer une table de multiplication");
        int table = int.Parse(Console.ReadLine());

        AfficherTableMult(table);
    }

    static void AfficherTableMult(int table)
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{i} x {table} = {i * table}");
        }

    }
}