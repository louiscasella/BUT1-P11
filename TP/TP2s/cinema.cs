using System;

class Cinema
{
    static void Main()
    {

        //decla variables
        double sommeTicket = 0;

        Console.WriteLine("Saisir nombre de ticket que vous voulez : ");
        int nbTicket = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nbTicket; i++)
        {
            if (i <= 5)
            {
                sommeTicket += 8;
            }
            else if (i > 5 && i <= 10)
            {
                sommeTicket += 6;
            }
            else
            {
                sommeTicket += 5.50;
            }
        }

        Console.WriteLine($"Vous avez acheter {nbTicket} tickets, cela vous revient à {sommeTicket} € !");

    }
}