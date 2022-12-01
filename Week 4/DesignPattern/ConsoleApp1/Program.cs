// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine();

var myclass1 = SinClass.GetInstance();

Console.WriteLine(myclass1.MyNumber); //13


myclass1.MyNumber = 15;

myclass1 = SinClass.GetInstance();
Console.WriteLine(myclass1.MyNumber); //13


var myclass2 = SinClass.GetInstance();
Console.WriteLine(myclass2.MyNumber);

