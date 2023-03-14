using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

while (true)
{

    Console.WriteLine("Veuillez selectionnez le nom: \nE) Édouard \nC) Constance");
    string personne = Console.ReadLine();
    try
    {
        switch (personne.ToUpper())
        {
            case "E":
                nbreMonster("E");
                break;
            case "C":
                nbreMonster("C");
                break;
            default:
                Console.WriteLine("no");
                Console.Clear();
                break;
        }

    }
    catch (Exception)
    {
        Console.WriteLine("Une erreur s'est produite...");
        break;
    }


}
void nbreMonster(string nom)
{
    Console.WriteLine("Veuillez entrez le nombre de canettes de boisson énergisante bues aujourd'hui");

    int total = Convert.ToInt32(Console.ReadLine());
    int nb = 0;
    string nomFichier = "monster.txt";

    using (StreamReader sr = new StreamReader(nomFichier))
    {

    }


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

    using (StreamWriter sw = new StreamWriter(nomFichier))
    {
        sw.WriteLine(total + nb);
    }


}

void afficherMenu(string n, string option1, string option2)
{

    Console.WriteLine($"Menu {n}");
    Console.WriteLine($"1) {option1}");
    Console.WriteLine($"2) {option2}");

}