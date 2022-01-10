// See https://aka.ms/new-console-template for more information
using LINQDemo.Model;
using System.Linq;

// Alice Andělová P1
// Bořivoj Bohatý P1
// Ctirad Cudný P2
// Daniela Drozdová P2

// ALG, PRG, MAT, CJL

// https://docs.microsoft.com/cs-cz/dotnet/csharp/programming-guide/concepts/linq/
// https://www.tutorialsteacher.com/linq
// https://www.geeksforgeeks.org/linq-method-syntax/?ref=lbp

// Where: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.where?view=net-6.0
// Order: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.orderby?view=net-6.0
// OrderByDescending: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.orderbydescending?view=net-6.0
// Select: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.select?view=net-6.0
// GroupBy: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.groupby?view=net-6.0
// Count: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.count?view=net-6.0
// Max: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.max?view=net-6.0
// Min: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.min?view=net-6.0
// Average: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.average?view=net-6.0
// Take: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.take?view=net-6.0



List<Mark> marks = new List<Mark> {
    new Mark("Alice","Andělová", "P1", "ALG", 1, new DateTime(2020,1,1)),
    new Mark("Bořivoj","Bohatý", "P1", "ALG", 3, new DateTime(2020,1,1)),
    new Mark("Ctirad","Cudný", "P2", "PRG", 1, new DateTime(2020,2,2)),
    new Mark("Daniela","Drozdová", "P2", "PRG", 5, new DateTime(2020,2,2)),
    new Mark("Alice","Andělová", "P1", "MAT", 2, new DateTime(2020,3,1)),
    new Mark("Bořivoj","Bohatý", "P1", "MAT", 3, new DateTime(2020,4,7)),
    new Mark("Ctirad","Cudný", "P2", "MAT", 3, new DateTime(2020,2,2)),
    new Mark("Daniela","Drozdová", "P2", "MAT", 5, new DateTime(2020,1,2)),
    new Mark("Alice","Andělová", "P1", "MAT", 2, new DateTime(2020,1,1)),
    new Mark("Bořivoj","Bohatý", "P1", "MAT", 4, new DateTime(2020,1,1)),
    new Mark("Ctirad","Cudný", "P2", "PRG", 2, new DateTime(2020,2,2)),
    new Mark("Daniela","Drozdová", "P2", "PRG", 5, new DateTime(2020,2,2)),
    new Mark("Alice","Andělová", "P1", "ALG", 4, new DateTime(2020,1,1)),
    new Mark("Bořivoj","Bohatý", "P1", "ALG", 4, new DateTime(2020,1,1)),
    new Mark("Ctirad","Cudný", "P2", "CJL", 2, new DateTime(2020,2,2)),
    new Mark("Daniela","Drozdová", "P2", "CJL", 5, new DateTime(2020,2,2)),
    new Mark("Alice","Andělová", "P1", "CJL", 1, new DateTime(2020,3,1)),
    new Mark("Bořivoj","Bohatý", "P1", "CJL", 3, new DateTime(2020,4,4)),
    new Mark("Ctirad","Cudný", "P2", "MAT", 1, new DateTime(2020,3,2)),
    new Mark("Daniela","Drozdová", "P2", "MAT", 5, new DateTime(2020,2,3))
};

// Seřaďte záznamy podle jména studenta
/*
var res1 = marks.OrderBy(m => m.FirstName);
foreach(var x in res1)
{
    Console.WriteLine(x);
}
*/

// Seřaďte záznamy podle data
/*
var res2 = marks.OrderBy(m => m.Created);
foreach (var x in res2)
{
    Console.WriteLine(x);
}
*/

// Seřaďte záznamy podle třídy sestupně
/*
var res1 = marks.OrderByDescending(m => m.ClassName);
foreach (var x in res1)
{
    Console.WriteLine(x);
}
*/
// Získejte jen známky studentky Alice
/*
var res1 = marks.Where(m => m.FirstName == "Alice");
foreach (var x in res1)
{
    Console.WriteLine(x);
}
*/
// Získejte jen známky z P1
/*
var res1 = marks.Where(m => m.ClassName == "P1");
foreach (var x in res1)
{
    Console.WriteLine(x);
}
*/

// Získejte jen známky z P1 seřazené podle příjmení studenta
/*
var res1 = marks
    .Where(m => m.ClassName == "P1")
    .OrderBy(m => m.LastName);
foreach (var x in res1)
{
    Console.WriteLine(x);
}
*/
// Získejte jen známky z P1, nezískávejte ale jiné informace kromě příjmení a známky
/*
var res1 = marks
    .Where(m => m.ClassName == "P1")
    .Select(m => new MarkVM { Name = m.LastName, Value = m.Value});
foreach (var x in res1)
{
    Console.WriteLine(x.LastName + " " + x.Value);
}
*/
// Kolik známek vlastně dostala dohromady třída P2?
/*
var res1 = marks.Where(m => m.ClassName == "P2").Count();
Console.WriteLine(res1);
*/
// Získejte průměr všech známek studentky Alice

/*
//var res1 = marks.Where(m => m.FirstName == "Alice").Average(m => m.Value);
var res1 = marks.Where(m => m.FirstName == "Alice").Select(m => new Decimal(m.Value)).Average();
Console.WriteLine(res1);
*/
// Získejte známky z jednotlivých předmětů studentky Alice
/*
var res1 = marks.Where(m => m.FirstName == "Alice").GroupBy(m => m.Subject);
foreach (var x in res1)
{
    Console.WriteLine("- " + x.Key);
    foreach(var y in x.OrderBy(m => m.Created).ToList())
    {
        Console.WriteLine(y);
    }
}
*/
// Získejte průměrné známky všech studentů
/*
var res1 = marks
    .GroupBy(m => m.LastName)
    .Select(m => new MarkVM { 
        Name = m.Key, 
        Value = (int)m.Average(n => n.Value) 
    });
foreach (var x in res1)
{
    Console.WriteLine(x.LastName + " " + x.Value);
}
*/
// Kolik známek dostala jaká třída?
/*
var res1 = marks
    .GroupBy(m => m.ClassName)
    .Select(m => new MarkVM
{
    Name = m.Key,
    Value = (int)m.Count()
});
foreach (var x in res1)
{
    Console.WriteLine(x.LastName + " " + x.Value);
}
*/
// Získejte nejvyšší známky všech studentů
/*
var heigher = marks
.GroupBy(x => x.LastName)
.Select(x => new MarkVM
{
    Name = x.Key,
    Value = (int)x.Max(x => x.Value)
});
foreach (var x in heigher)
{
    Console.WriteLine(x.LastName + " " + x.Value);
}
*/
// Seřaďte studenty podle jejich průměrných známek
var res1 = marks
    .GroupBy(m => m.LastName)
    .Select(m => new MarkVM
    {
        Name = m.Key,
        Value = (int)m.Average(n => n.Value)
    })
    .OrderBy(x => x.Value);
foreach (var x in res1)
{
    Console.WriteLine(x.Name + " " + x.Value);
}
