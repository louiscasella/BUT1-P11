using System;

class Dicho
{
    static void Main()
    {
        int[] tableau = {5, 11, 19, 38, 54, 55, 78, 87, 100, 105};

        Console.WriteLine("Entrer nombre à rechercher : ");
        int nb = int.Parse(Console.ReadLine());

        int indice = RechercheDichotomique(nb, tableau);
        Console.WriteLine($"L'indice de {nb} est : {indice}");
    }

    static int RechercheDichotomique(int val, int[] tab)
    {   

        //declaration des variables
        int debut = 0;
        int fin = tab.Length - 1;
        int milieu;
        bool find = false;
        int indice = -1;
        
        //Tant que la valeur n'est pas trouvé faire
        while (find == false && debut <= fin)
        {   
            milieu = (debut + fin) / 2;

            if (tab[milieu] == val)  //cas ou la valeur est égale au milieu
            {
                find = true;
                indice = milieu;
            }

            else if (tab[milieu] < val )  // cas ou la valeur est supérieure au milieu
            {
                debut = milieu + 1;
            }

            else    // cas ou la valeur est inférieure au milieu
            {
                fin = milieu - 1;
            }
        }

        return (indice);
    }
}