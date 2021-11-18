using OperatorOverload;

// Lze přetížit: x + y, x-y, x * y, x/y, x% y, x & y, x | y, x ^ y, x << y, x >> y, x = = y, x! = y, x < y, x > y, x <= y, x > = y
// https://docs.microsoft.com/cs-cz/dotnet/csharp/language-reference/operators/operator-overloading

DataItem a = new DataItem(4, "rohlík");
DataItem b = new DataItem(6, "paprik");
Console.WriteLine(a + b); // 10 něco
Console.WriteLine(a + 7); // 11 rohlík