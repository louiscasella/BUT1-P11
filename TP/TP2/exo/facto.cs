using System;

class Facto
{

    static void Main()
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
}