using System;

class test
{
    static void Main()
    {

        int[] tab = { 0, 6, 5, 4, 6, 3, 4, 7, 5, 6, 6 };

        int[,] freqDecroi = new int[2, tab.Length];

        for (int i = 0; i < tab.Length; i++)
        {
            freqDecroi[0, i] = i;
            freqDecroi[1, i] = tab[i];
        }

        int tempVal, tempIndex;

        for (int i = 0; i < tab.Length - 1; i++)
        {
            for (int j = 0; j < tab.Length - i - 1; j++)
            {
                if (freqDecroi[1, j] < freqDecroi[1, j + 1])
                {

                    tempVal = freqDecroi[1, j];
                    freqDecroi[1, j] = freqDecroi[1, j + 1];
                    freqDecroi[1, j + 1] = tempVal;

                    tempIndex = freqDecroi[0, j];
                    freqDecroi[0, j] = freqDecroi[0, j + 1];
                    freqDecroi[0, j + 1] = tempIndex;
                }
            }
        }

        Afficher(freqDecroi);
        afficherFrequenceDecroi(freqDecroi);



    }
    
    static void afficherFrequenceDecroi(int[,] tab)
    {

        int sommeFrequence = 0;

        for (int i = 0; i < tab.GetLength(1); i++)
        {
            sommeFrequence += tab[1, i];
        }
        
        for (int i = 0; i < tab.GetLength(1) - 1; i++)
        {
            double pourcentage = (double)tab[1, i] / sommeFrequence * 100;  
            Console.WriteLine($"{tab[0, i]} ({pourcentage.ToString("F2")}%)");
        }
    }
    
    static void Afficher(int[,] tab)
    {
        for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int j = 0; j < tab.GetLength(1); j++)
            {
                Console.Write(tab[i,j]+" ");
            }
            
            Console.WriteLine();
        }
    }
    
}