using System;

class exo2
{

    struct Etudiant
    {
        public string nom;
        public string prenom;
        public int groupe;
        public double[] resultats;
        public int nbNotes;
        public double moyenne;

        public Etudiant(string p, string n, int g)
        {   
            prenom = p;
            nom = n;
            groupe = g;
            nbNotes = 0;
            moyenne = 0;
            
            resultats = new double[6];

            for (int i = 0; i <= 5; i++)
            {
                resultats[i] = 0;
            }

        }
    }

    static void Main()
    {
        Etudiant etu = new Etudiant("Albert", "Einstein", 1);
        AfficherEtudiant(etu);

        AjouterNote(ref etu, 10);
        AjouterNote(ref etu, 15);
        AjouterNote(ref etu, 7.5);
        AjouterNote(ref etu, 7.5);
        AjouterNote(ref etu, 13.25);
        AjouterNote(ref etu, 18);

        AfficherEtudiant(etu);

        
    }

    static void AfficherEtudiant(Etudiant etu)
    {
        Console.WriteLine($"Etudiant(e) : {etu.prenom} {etu.nom} Groupe {etu.groupe}");
        Console.WriteLine($"Notes : < {etu.resultats[0]} {etu.resultats[1]} {etu.resultats[2]} {etu.resultats[3]} {etu.resultats[4]} {etu.resultats[5]} > moyenne {etu.moyenne} ({etu.nbNotes} notes renseignées).");
    }

    static void AjouterNote(ref Etudiant etu, double note)
    {
        
        double moyenne = 0;

        if (etu.nbNotes == 6)
        {
            Console.WriteLine("Y'a deja toutes les notes ducon");
        }

        else
        {
            etu.resultats[etu.nbNotes] = note;

            etu.nbNotes++;

            for (int i = 0; i <= 5; i++)
            {
                moyenne += etu.resultats[i];
            }

            moyenne /= etu.nbNotes;

            etu.moyenne = moyenne;

            Console.WriteLine("Note insérée.");
        }

    }

}