// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class Program
{
    static void Main(string[] args)
    {
        Fighter fighter = new Fighter();
        fighter.Nombre = "John Doe";
        fighter.Peso = 150;

        Console.WriteLine("Nombre del luchador: " + fighter.Nombre);
        Console.WriteLine("Peso del luchador: " + fighter.Peso + " lbs");
        Console.WriteLine("Categoría del luchador: " + fighter.Categoria);
    }
}
