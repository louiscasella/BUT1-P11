using System;

class Date
{

    static void Main()
    {

        //declaration des variables
        Console.WriteLine("Donnez le jour :");
        int jour = int.Parse(Console.ReadLine());

        Console.WriteLine("Donnez le mois :");
        int mois = int.Parse(Console.ReadLine());

        Console.WriteLine("Donnez l'année :");
        int annee = int.Parse(Console.ReadLine());


    }

    //verification via fonctions dédiées
    static bool IsYearRight(int jour, int mois, int annee)
    {
        if (annee <= 1901 && annee >= 2038)
        {
            if (annee == 1901 && mois < 12)
            {
                return false;
            }

            else if (annee == 2038 && mois > 1)
            {
                return false;
            }

            else if (annee == 1901 && mois == 12 && jour < 13)
            {
                return false;
            }

            else if (annee == 2038 && mois == 1 && jour > 19)
            {
                return false;
            }
        }

        else
        {
            return true;
        }

    }

    static bool IsMonth(int mois)
    {
        if (mois < 1 && mois > 12)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static bool IsDay(int jour)
    {
        if (jour < 1 && jour > 31)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static bool IsBissextile(int annee)
    {

        if (mois % 400)
        if (mois % 4 == 0 && mois % 100 != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    
}