// See https://aka.ms/new-console-template for more information
Console.WriteLine("");

Property property = new Property();

Console.WriteLine("Introduce la ubicaacion de tu casa");

property.Address = new Address();

Console.WriteLine("Introduce la calle de la propiedad");
property.Address.Street = Console.ReadLine();

Console.WriteLine("Introduce el precio de renta / venta");

property.Price = Decimal.Parse(  Console.ReadLine());


Console.ReadLine();

Console.WriteLine ($"Se renta o vende una propiedad ubicada en {property.Address.Street} en {property.Price}");

