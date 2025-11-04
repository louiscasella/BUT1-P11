using System;

class Ex6
{
    static void Main()
    {
        Console.WriteLine("Rentrer factorielle de : ");
        int n = int.Parse(Console.ReadLine());

        int res = Facto(n);

        if (res >= 0)
        {
            Console.WriteLine($"{n}! = {res}");
        }
        else
        {
            Console.WriteLine("Le nombre doit etre prositif !");
        }
    }

    static int Facto(int n)
    {   

        int facto = 1;

        if (n >= 0)
        {
            for (int i = 1; i<=n; i++)
            {
                facto*=i;
            }

            return facto;
        }
        else 
        {
            return -1;
        }
    }
}