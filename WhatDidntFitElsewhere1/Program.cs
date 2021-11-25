// See https://aka.ms/new-console-template for more information
using WhatDidntFitElsewhere1;

Gender x = Gender.Male;
GeoCoordinates school = new GeoCoordinates(50.45,15.12);
GeoCoordinates school2 = school;
school2.Latitude = 52;
Console.WriteLine(school);
Console.WriteLine(school2);
Console.WriteLine((int)x);

int[] pole = new int[]{ 1, 2, 3, 4, 5 };
//pole[5] = 6;
int[] temp = new int[pole.Length + 1];
for(int i = 0; i < pole.Length; i++)
{
    temp[i] = pole[i];
}
pole = temp;
pole[5] = 6;
foreach(int r in pole)
{
    Console.WriteLine(r);
}
/*
ppppptttttt
00000pppppp
pppppp
*/