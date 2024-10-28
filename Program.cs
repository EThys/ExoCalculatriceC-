// See https://aka.ms/new-console-template for more information


using calculatrice;

bool continuer = true;

while (continuer)
{
    Console.WriteLine("Entrer le premier nombre");
    string? firstNbr = Console.ReadLine();
    Console.WriteLine("Entrer le second nombre");
    string? secondNbr = Console.ReadLine();
    Console.WriteLine("Entrer l'opération (Addition, Soustraction, Multiplication, Division, Modulo)");
    string? operation = Console.ReadLine();

    
    if (int.TryParse(firstNbr, out int convertFirstNbr) && int.TryParse(secondNbr, out int convertSecondNbr))
    {
        Calculatrice calc = new Calculatrice(convertFirstNbr, convertSecondNbr);
        int resultat = 0;
        bool operationValide = true; 

        switch (operation)
        {
            case "Addition":
                resultat = calc.Addition(convertFirstNbr, convertSecondNbr);
                break;
            case "Soustraction":
                resultat = calc.Soustraction(convertFirstNbr, convertSecondNbr);
                break;
            case "Multiplication":
                resultat = calc.Multiplication(convertFirstNbr, convertSecondNbr);
                break;
            case "Division":
                if (convertSecondNbr != 0) 
                {
                    resultat = calc.Division(convertFirstNbr, convertSecondNbr);
                }
                else
                {
                    Console.WriteLine("Erreur : Division par zéro.");
                    operationValide = false; 
                }
                break;
            case "Modulo":
                if (convertSecondNbr != 0) 
                {
                    resultat = calc.Modulo(convertFirstNbr, convertSecondNbr);
                }
                else
                {
                    Console.WriteLine("Erreur : Division par zéro pour le modulo.");
                    operationValide = false;
                }
                break;
            default:
                Console.WriteLine("Erreur : Opération non valide.");
                operationValide = false; 
                break;
        }

        if (operationValide) 
        {
            Console.WriteLine($"Le résultat vaut {resultat}");
        }
    }
    else
    {
        Console.WriteLine("Veuillez entrer des nombres valides.");
    }

    Console.WriteLine("Voulez-vous effectuer un autre calcul ? (o/n)");
    string? reponse = Console.ReadLine();
    continuer = reponse?.ToLower() == "o"; 
}













// using calculatrice;

// Console.WriteLine("Entrer le premier nombre");
// string ? firstNbr = Console.ReadLine();
// Console.WriteLine("Entrer le second nombre");
// string ? secondNbr = Console.ReadLine();
// Console.WriteLine("Entrer l'operation");
// string ? operation = Console.ReadLine();

// int convertFirstNbr=Convert.ToInt32(firstNbr);
// int convertSecondNbr=Convert.ToInt32(secondNbr);

// Calculatrice calc=new Calculatrice(convertFirstNbr,convertSecondNbr);
// int resultat=0;

// switch (operation)
// {
//     case "Addition":
//         resultat=calc.Addition(convertFirstNbr,convertSecondNbr);
//         break;
//     case "Multiplication":
//         resultat=calc.Multiplication(convertFirstNbr,convertSecondNbr);
//         break;
//     case "Division":
//         resultat=calc.Division(convertFirstNbr,convertSecondNbr);
//         break;
//     case "Soustraction":
//         resultat=calc.Division(convertFirstNbr,convertSecondNbr);
//         break;
//     case "Modulo":
//         resultat=calc.Modulo(convertFirstNbr,convertSecondNbr);
//         break;
//     default:
//         break;
// }

// Console.WriteLine($"Le resultat vaut {resultat}");