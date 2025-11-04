using System;

class CompteA
{

    static void Main()
    {

        //definition variable
        int somme = 0;
        char caract = ' ';
        int i = 0;

        while (caract != '*')
        {
            Console.WriteLine("Saisir un caractere :");
            caract = char.Parse(Console.ReadLine());

            if (caract == 'A' || caract == 'a')
            {
                somme++;
            }

            i++;
        }
        
        Console.WriteLine($"Vous avez saisi {i-1} caracteres, \ndont {somme} 'A' ou 'a' \nCe qui fait une fréquence de : {(float)somme/(i-1)}");

    }

}