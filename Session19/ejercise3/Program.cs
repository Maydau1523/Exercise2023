// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


using System;

class Program
{
    struct Libro
    {
        public string titulo;
        public string autor;
    }

    static void Main(string[] args)
    {
        Libro libro1, libro2;

        Console.WriteLine("Información del libro 1:");
        Console.Write("Ingrese el nombre del libro: ");
        libro1.titulo = Console.ReadLine();
        Console.Write("Introduzca el autor: ");
        libro1.autor = Console.ReadLine();

        Console.WriteLine("Información del libro 2:");
        Console.Write("Ingrese el nombre del libro: ");
        libro2.titulo = Console.ReadLine();
        Console.Write("Introduzca el autor: ");
        libro2.autor = Console.ReadLine();

        Console.WriteLine("Rendimiento esperado:");
        Console.WriteLine("1: Título = {0}, Autor = {1}", libro1.titulo, libro1.autor);
        Console.WriteLine("2: Título = {0}, Autor = {1}", libro2.titulo, libro2.autor);
    }
}
