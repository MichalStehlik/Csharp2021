// See https://aka.ms/new-console-template for more information
using Generics;

var x1 = new ContainerInt(4);
Console.WriteLine(x1);
var x2 = new ContainerDouble(4.4);
Console.WriteLine(x2);
var x3 = new ContainerString("Ahoj");
Console.WriteLine(x3);
var y1 = new Container<int>(4);
Console.WriteLine(y1);
var y2 = new Container<double>(4.4);
Console.WriteLine(y2);
var y3 = new Container<string>("Ahoj");
Console.WriteLine(y3);
var z = new Operations<int, double>(4, 4.0);
Console.WriteLine(z.IsEqual);