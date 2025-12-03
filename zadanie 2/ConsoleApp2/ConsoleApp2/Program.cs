using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string sciezkaWejsciowa = "ranking_raw.txt";
        string sciezkaWyjsciowa = "ranking_clean.txt";
        
        if (!File.Exists(sciezkaWejsciowa)) return;

        List<string> linieWejsciowe = new List<string>(File.ReadAllLines(sciezkaWejsciowa));
        List<string> linieWyjsciowe = new List<string>();
        
        if (linieWejsciowe.Count > 0)
        {
            linieWyjsciowe.Add(linieWejsciowe[0]);
        }

        for (int i = 1; i < linieWejsciowe.Count; i++)
        {
            string linia = linieWejsciowe[i];
            if (string.IsNullOrWhiteSpace(linia)) continue;

            string[] pola = linia.Split(';');
            
            if (pola.Length != 5) continue; 
            
            string Nick = pola[0]; 
            string Czas = pola[1]; 
            string Punkty = pola[2]; 
            string Status = pola[3]; 
            string Opis = pola[4]; 
            
            bool doUsuniecia = false;
            
            if (Status.ToUpper() == "HACKER")
            {
                doUsuniecia = true;
            }
            
            if (Czas == "00:00:01" || Czas == "0:00:01")
            {
                doUsuniecia = true;
            }

            if (doUsuniecia) continue; 
            
            int punktyPoprawione;
            if (!int.TryParse(Punkty, out punktyPoprawione))
            {
            }
            
            string nowaLinia = Nick + ";" + Czas + ";" + punktyPoprawione + ";" + Status + ";" + Opis;
            linieWyjsciowe.Add(nowaLinia);
        }
        
        File.WriteAllLines(sciezkaWyjsciowa, linieWyjsciowe);
        
        Console.WriteLine("=== ZAWATOŚĆ OCZYSZCZONEGO PLIKU ===");
        foreach (string l in linieWyjsciowe)
        {
            Console.WriteLine(l);
        }
    }
}