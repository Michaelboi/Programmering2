using System;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using lösenorduppgift;
using uppgift3;

/*namespace programmering
{
    class Lösenord
    {
        private string lösenord;
        public string inputlösenord
        {
            return
        }
        
    }
}
*/
// Uppgift 1
// Olle, du sa att min lösning var OK.
/*void GenerateNumbers()
{
    // ger X ett random nummer
    Random X = new Random();
    int? value = X.Next(0, 10);
    int[] numberX = new int[5];
    // en funktion som tar bort duplicates
    void RemoveDuplicate()
    {
        int[] removedup = numberX.Distinct().ToArray();
        Array.ForEach(removedup, x => Console.WriteLine("X = " + x));
    }
    // sätter in 5 random värden från X i listan numberX
    for (int i = 0; i < numberX.Length; i++)
    {
        numberX[i] = X.Next(0,10);
    }
    // kallar på funktionen som skannar listan efter duplicates och tar bort dom.
    RemoveDuplicate();
    // strunta i detta
    if (numberX == null || numberX!.Contains(5))
    {
        RemoveDuplicate();
    }

}

GenerateNumbers();

    //instansierar random i X och Y variablerna
    var X = new Random();
    var Y = new Random();
    //Den här skapar en lista i en variabel med 5 tomma celler med värden mellan 0-10
    int[] numberX = new int[5]; 
    Enumerable.Range(0, 6).OrderBy(x => X.Next()).Take(5).ToList();
    int[] numberY = new int[5];
    Enumerable.Range(0, 6).OrderBy(y => Y.Next()).Take(5).ToList();
    //En loop som loopar igenom de olika variablerna som har har listor.
    for (int i = 0; i < numberX.Length; i++)
    {
        Console.WriteLine("(" + numberX[i] + "," + numberY[i] + ")");
        
        
    }
        

}
GenerateNumbers();
*/
/*
void Lösenord()
{
    // variabel för input
    string input = "";
    // skapar ny variabel från klassen
    information.lösenordinfo sparatlösenord = new information.lösenordinfo();
    Console.Write("Skapa lösenord mellan 3 till 10 karaktärer: ");
    // loopar igenom så att man kan fortsätta efter att den har tagit in input som ett sparat lösenord.
    while (input != "ex")
    {
        input = Console.ReadLine();
        if (input.Length > 3 && input.Length < 10)
        {
            sparatlösenord.setlösenord(input);
            Console.WriteLine("lösenord är sparat, vill du se ditt lösenord? Y/N");
            if (input.Length < 3 || input.Length > 10)
            {
                Console.WriteLine("läs texten idiot");
            }
        }
        
        if (input == "Y")
        {
            Console.WriteLine(sparatlösenord.visalösenord());

        }

    }
    
}
Lösenord();
*/

static void Konto()
{
    var konto1 = new Bank("Elias", 10000, "2929 9238 1948");
    var konto2 = new Bank("Lukas", 20, "2020 6969 0911");
    Console.WriteLine($"Kontot med {konto1.Kortnummer} har skapats till {konto1.Ägare} med {konto1.Balance} kr");
    
}
Konto();


