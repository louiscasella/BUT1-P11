using System;

class Exo4
{
    static void Main()
    {

        Console.WriteLine("entrer un premier nombre : ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("entrer un second nombre : ");
        double b = double.Parse(Console.ReadLine());

        int res = Compare(a,b);

        switch(res)
        {
            case 1:
                Console.WriteLine($"{a} est plus grand que {b} !");
                break;
            case -1:
                Console.WriteLine($"{a} est plus petit que {b} !");
                break;
            case 0:
                Console.WriteLine($"{a} est égal à {b} !");
                break;
        }

    }

    static int Compare(double a, double b)
    {
        if (a > b)
        {
            return 1;
        }
        else if (a < b)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}