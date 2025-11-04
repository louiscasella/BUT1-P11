using System;

class Exo3
{
    static void Main()
    {
        Console.WriteLine("Donner heures");
        int h = int.Parse(Console.ReadLine());

        Console.WriteLine("Donner minutes");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine(heureVersMin(h,m));
    }

    static int heureVersMin(int heure, int minute)
    {
        if (heure >= 0 && minute >= 0 && minute < 60)
        {
            int res = 60 * heure + minute;
            return res;
        }
        
        else
        {
            return -1;
        }
    }
}