using System;
using System.Globalization;
using System.IO;

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

        if (File.Exists("Promotion.csv"))
        {
            string[] lignes = File.ReadAllLines("Promotion.csv");

            int NbEtu = lignes.Length;

            double sommePromo = 0;
            double nbNotePromo = 0;

            double SommeGroupe = 0;
            double nbNoteGroupe = 0;

            Etudiant[] promotion = new Etudiant[NbEtu];

            for (int i = 0; i < NbEtu; i++)
            {

                string[] temp = lignes[i].Split(";");

                promotion[i] = new Etudiant(temp[0], temp[1], int.Parse(temp[2]));

                for (int j = 3; j < temp.Length; j++)
                {
                    AjouterNote(ref promotion[i], double.Parse(temp[j].Replace(",", ".")));

                    sommePromo += double.Parse(temp[j].Replace(",", "."));
                    nbNotePromo++;
    
                }

            }

            foreach (Etudiant etu in promotion)
            {
                AfficherEtudiant(etu);
            }

            Console.WriteLine($"\nLa moyenne de la promo est : {sommePromo / nbNotePromo}");
            
        }
        
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