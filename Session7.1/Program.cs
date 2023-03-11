// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escribe un numeros impares");

class NumerosImpares
{
    static void Main(string[] args)
    {
        Console.WriteLine("Imprimir numeros impares del 1 al 99");

        for (int i = 1; i < 100; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadKey();
    }

    





