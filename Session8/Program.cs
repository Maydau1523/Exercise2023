// See https://aka.ms/new-console-template for more information
Console.WriteLine("Perimetro y area de figuras");

class PerimetroArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el ancho del rectángulo:");
        double ancho = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del rectángulo:");
        double altura = double.Parse(Console.ReadLine());

        double perimetro = 2 * (ancho + altura);
        double area = ancho * altura;
        double diagonal = Math.Sqrt(Math.Pow(ancho, 2) + Math.Pow(altura, 2));

        Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
        Console.WriteLine($"El área del rectángulo es: {area}");
        Console.WriteLine($"La diagonal del rectángulo es: {diagonal}");

        Console.ReadLine();
    }
}

