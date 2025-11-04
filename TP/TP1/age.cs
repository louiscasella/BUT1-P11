using System;

class Exo8
{

    static void Main()
    {

        //declaration variables
        int age;

        //saisie
        Console.WriteLine("Donnez votre âge : ");
        age = int.Parse(Console.ReadLine());

        //Verification et calcules
        if (age > 0 && age < 122)
        {

            if (age >= 18)
            {
                Console.WriteLine($"Vous avez {age} ans, vous êtes donc majeur !");
            }
            else
            {
                Console.WriteLine($"Vous avez {age} ans, vous êtes donc mineur !");
            }

        }
        else
        {
            Console.WriteLine("/!\\ Saisie incorrecte, l'age doit etre entre 0 et 122 ans");
        }
        
    }
}