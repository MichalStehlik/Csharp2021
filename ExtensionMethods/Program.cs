// See https://aka.ms/new-console-template for more information

// https://docs.microsoft.com/cs-cz/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
// https://www.c-sharpcorner.com/uploadfile/puranindia/extension-methods-in-C-Sharp-3-0/
//
// Pokusme se rozšířit obyčejný List (IEnumerable) o nové metody, které původně určitě neobsahoval

using ExtensionMethods;

List<string> strings = new List<string> // určitě neobsahuje metody IsCountEven(), Even(), ShorterThen(int)
{
    "Anna",
    "Bonifác",
    "Cecílie",
    "Daniel",
    "Ervin",
    "Flora",
    "Gabriel",
    "Herbert"
};
foreach (string s in strings)
{
    Console.WriteLine(s);
}

// První metoda bude vracet informaci o tom, zda List obsahuje sudý nebo lichý počet položek
Console.WriteLine("---");
// Console.WriteLine(MyExtensions.IsCountEven(strings));
Console.WriteLine(strings.IsCountEven());

// Druhá metody bude vracet jen ty položky Listu, které jsou kratší než daný počet znaků
Console.WriteLine("---");

foreach (string s in strings.ShorterThen(5))
{
    Console.WriteLine(s);
}

// Třetí metoda bude vracet jen sudé položky Listu
Console.WriteLine("---");

foreach (string s in strings.Even())
{
    Console.WriteLine(s);
}


// Čtvrtá metoda bude vracet jen ty položky Listu, které splní podmínku danou Lambda výrazem
Console.WriteLine("---");
foreach (string s in strings.Condition(listItem => listItem.Length > 6))
{
    Console.WriteLine(s);
}

foreach (string s in strings.Condition(listItem => listItem.Length < 5))
{
    Console.WriteLine(s);
}