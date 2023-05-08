// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


using System;

struct Punto
{
    public short x;
    public short y;
}

class Program
{
    static void Main(string[] args)
    {
        Punto punto1, punto2;

        // Ingresar datos del primer punto
        punto1.x = 3;
        punto1.y = 5;

        // Ingresar datos del segundo punto
        punto2.x = -2;
        punto2.y = 7;

        // Mostrar los puntos
        Console.WriteLine($"Primer punto: ({punto1.x}, {punto1.y})");
        Console.WriteLine($"Segundo punto: ({punto2.x}, {punto2.y})");
    }
}

