using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

while (true)
{
    Console.Clear();
    Console.WriteLine("Veuillez selectionnez l'option: " +
        "\nA) Ajouter des canettes " +
        "\nS) Soustraire" +
        "\nT) Test pas rapport\n");
    string choix = Console.ReadLine();
    switch (choix.ToUpper())
    {
        case "A":
            afficherMenu("plus");
            break;
        case "S":
            afficherMenu("moins");
            break;
        case "T":
            testPasRapport();
            break;
        default:
            break;
    }
    afficherStats();
    Console.ReadKey();

}

void afficherMenu(string operateur)
{
    Console.WriteLine("Veuillez selectionnez le nom: \nE) Édouard \nC) Constance");
    string personne = Console.ReadLine();

    switch (personne.ToUpper())
    {
        case "E":
            nbreMonster("E", operateur);
            break;
        case "C":
            nbreMonster("C", operateur);
            break;
        default:
            Console.WriteLine("no");
            Console.Clear();
            break;
    }
}

void testPasRapport()
{
    Console.WriteLine("Test Pas Rapport");
    return;
}

void nbreMonster(string nom, string operateur)
{
    string nomFichier = " ";
    switch (nom)
    {
        case "E":
            nomFichier = "E.txt";
            break;
        case "C":
            nomFichier = "C.txt";
            break;
        default:
            break;
    }

    Console.WriteLine("Veuillez entrez le nombre de canettes bues aujourd'hui");

    int nbUser = Convert.ToInt32(Console.ReadLine());


    //Console.WriteLine(nbUser);
    //int total = 0;

    //using (StreamReader sr = new StreamReader(nomFichier))
    //{
    //    total = Convert.ToInt32(sr.ReadLine()) + nbUser;
    //}
    switch (operateur)
    {
        case "plus":
            using (StreamWriter sw = new StreamWriter(nomFichier, true))
            {
                sw.WriteLine(nbUser);
            }
            break;

        case "moins":
            using (StreamWriter sw = new StreamWriter(nomFichier, true))
            {
                sw.WriteLine("-"+nbUser);
            }
            break;
        default:
            break;
    }

    Console.Clear();

}


static int CalcStatsDansFichier(string nom)
{
    int sum = 0;
    using (StreamReader sr = new StreamReader(nom))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            int value;
            if (int.TryParse(line, out value))
            {
                sum += value;
            }
        }
    }
    return sum;
}

void afficherStats()
{
    int totalC;
    int totalE;

    totalC = CalcStatsDansFichier("C.txt");
    totalE = CalcStatsDansFichier("E.txt");
    //using (StreamReader sr = new StreamReader("C.txt"))
    //{
    //    totalC = Convert.ToInt32(sr.ReadToEnd());
    //}
    //using (StreamReader sr = new StreamReader("E.txt"))
    //{
    //    totalE = Convert.ToInt32(sr.ReadToEnd());
    //}

    Console.WriteLine($"Stats");
    Console.WriteLine($"Édouard:        {totalE}");
    Console.WriteLine($"Constance:      {totalC}");
    Console.WriteLine("Appuyez sur une touche pour continuer");
}