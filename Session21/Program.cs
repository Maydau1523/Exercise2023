// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var puma = new Animal();
puma.Patas = 4;
puma.Name = "Puma";

var puma2 = new Animal();
puma2.Patas = 4;
puma2.Name = "Puma";


Console.WriteLine("Los pumas son iguales {0}", puma == puma2);


var puma3 = new AnimalRecord("puma Negro", 4);
var puma4 = new AnimalRecord("puma Negro", 4);

Console.WriteLine($"el puma 3 es {puma3}");

Console.WriteLine($"el puma 3 es igual {puma3 == puma4}");

