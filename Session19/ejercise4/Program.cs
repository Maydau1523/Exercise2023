// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using System;

struct Cuadrado
{
    public int largo;
    public int ancho;
}

class Program
{
    static Cuadrado ObtenerCuadrado()
    {
        Cuadrado cuadrado;

        Console.WriteLine("Ingrese las dimensiones del Cuadrado (igual largo y ancho):");
        Console.Write("Largo: ");
        cuadrado.largo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ancho: ");
        cuadrado.ancho = Convert.ToInt32(Console.ReadLine());

        return cuadrado;
    }

    static void Main(string[] args)
    {
        Cuadrado miCuadrado = ObtenerCuadrado();

        int perimetro = (miCuadrado.largo + miCuadrado.ancho) * 2;
        int area = miCuadrado.largo * miCuadrado.ancho;

        Console.WriteLine("Perímetro y Área del cuadrado:");
        Console.WriteLine("Largo: {0} Ancho: {1}", miCuadrado.largo, miCuadrado.ancho);
        Console.WriteLine("Perímetro: {0} Área: {1}", perimetro, area);
    }
}

