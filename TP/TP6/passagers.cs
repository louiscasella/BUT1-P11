using System;
using System.Collections;
using System.IO;

class exo1
{

    static void Main()
    {   

        string ligne;
        string[] temp;
        char[] separateur = new char[] { ';' };
        StreamReader passagers = null;
        int y = 0, w = 0, j = 0, f = 0;

        if (File.Exists("Passagers.csv"))
        {
            FileStream fs = new FileStream("Passagers.csv", FileMode.Open, FileAccess.Read);
            passagers = new StreamReader(fs);
        }

        Console.WriteLine("Numéro Nom       Prénom  Classe");
        Console.WriteLine("-------------------------------");

        while (!passagers.EndOfStream)
        {
            ligne = passagers.ReadLine();
            temp = ligne.Split(separateur);

            switch(temp[3])
            {
                case "Y":
                    y++;
                    break;
                
                case "W":
                    w++;
                    break;

                case "J":
                    j++;
                    break;
                
                case "F":
                    f++;
                    break;
            }

            Console.Write($"{temp[0]}".PadRight(7));
            Console.Write($"{temp[1]}".PadRight(10));
            Console.Write($"{temp[2]}".PadRight(8));
            Console.Write($"{temp[3]}");
            Console.WriteLine();
        }

        passagers.Close();

        Console.WriteLine("-------------------------------");
        Console.WriteLine($"Classe Y --> {y}");
        Console.WriteLine($"Classe W --> {w}");
        Console.WriteLine($"Classe J --> {j}");
        Console.WriteLine($"Classe F --> {f}");
    }
}