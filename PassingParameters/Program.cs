// hodnoty lze do metod předávat hodnotou nebo referencí
// --- Předání hodnotou
// V metodě založena nová proměnná a do té je vložena daná hodnota.
// Při opuštění metody je tato proměnná zahozena a všechny její úpravy zapomenuty
// Takto jsou předávány elementární datové typy: int, bool, double
// --- Předání referencí
// Je předána adresa proměnné a s tou se dál normálně pracuje
// Na stejné místo v paměti tak směřuje jak vnitřní proměnná metody, tak i ta původní proměnná
// Všechny změny proměnné uvnitř metody se projeví i mimo metodu
// Takto jsou standardně předávány pole, objekty a řetězce

int squareVal(int x) // předání hodnotou
{
    x = x * x;
    return x;
}

int squareRef(ref int x) // předání referencí si pro int musíme vynutit
{
    x = x * x;
    return x;
}

int a1 = 2; // proměnná a1 je umístěna v paměti na adrese X a má hodnotu 1
int a2 = 2;
squareVal(a1);
squareRef(ref a2);

Console.WriteLine("VAL:" + a1);
Console.WriteLine("REF:" + a2);

// Další způsob předání referencí je pomocí fráze out, která je vhodná tam, kde potřebujeme z metody vrátit větší množství proměnných
int Powers(int x, out int x3, out int x4)
{
    x3 = x * x * x;
    x4 = x * x * x * x;
    return x * x;
}

int b = 2;
int b2;
int b3; // proměnné musí existovat předem
int b4;
b2 = Powers(b, out b3, out b4);
Console.WriteLine(b2 + " " + b3 + " " + b4);