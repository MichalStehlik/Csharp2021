// See https://aka.ms/new-console-template for more information
using System.Text;

string a = "Ahoj";
String b = "Ahoj";
Console.WriteLine(a);
// Mutable
// Immutable
string c = "Ahoj"; // 111111111
c = c + " P2";     // .........22222222222
Console.WriteLine(c);
// garbage collector // 2222222222
Console.WriteLine(String.Compare(a,b)); // -1,0,1 // jak se řadí?
Console.WriteLine(String.Equals(a, b)); // jsou stejné?
Console.WriteLine(String.IsNullOrEmpty(c));
Console.WriteLine(String.IsNullOrWhiteSpace(c));
Console.WriteLine(a.Contains("ho"));
Console.WriteLine(a.Remove(1));
Console.WriteLine(a.Replace("o", "x"));
Console.WriteLine(a.Insert(2,"co"));
Console.WriteLine(a.Substring(1));
Console.WriteLine(a.Substring(1,2));
StringBuilder sb = new StringBuilder("Ahoj");
Console.WriteLine(sb);
sb.Append(" Evropo");
sb.Append("!");
sb.Append(6);
Console.WriteLine(sb);