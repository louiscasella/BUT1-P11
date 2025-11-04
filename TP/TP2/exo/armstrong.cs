using System;

class Armstrong
{

    static void Main()
    {

        //decla constante
        int BORNE_MIN = 2;
        int BORN_MAX = 999;
        int NB_ARMSTRONG = 4;

        //decla variables
        int c, d, u, n, temp, nbA;

        //debut
        n = BORNE_MIN;
        nbA = 0;

        while (n <= BORN_MAX && nbA < NB_ARMSTRONG)
        {
            c = n / 100;
            temp = n % 100;
            d = temp / 10;
            u = temp % 10;

            if (c * c * c + d * d * d + u * u * u == n)
            {
                Console.WriteLine(n);
                nbA++;
            }

            n++;
        }
        
    }

}