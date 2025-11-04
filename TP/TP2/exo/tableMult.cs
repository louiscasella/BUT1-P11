using System;

class TableMultiplication
{

    static void Main()
    {

        //declaration des variables
        Console.WriteLine("Rentrer numéro de la table de multiplication : ");
        int table = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {   
            Console.WriteLine($"{i} x {table} = {i*table}");
        }

    }

}