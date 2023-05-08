// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Program
{
    static void Main()
    {
        short x, y;

        Console.Write("Ingrese las coordenadas x e y del punto: ");
        string[] coordenadas = Console.ReadLine().Split(' ');

        x = Convert.ToInt16(coordenadas[0]);
        y = Convert.ToInt16(coordenadas[1]);

        Console.WriteLine("Las coordenadas del punto son: ({0}, {1})", x, y);
    }
}



