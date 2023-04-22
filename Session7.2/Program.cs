// See https://aka.ms/new-console-template for more information
Console.WriteLine("valor absoluto de numero");


class ValorAbsoluto

{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        int diferencia = Math.Abs(num1 - num2);

        if (num1 > num2)
        {
            int dobleDiferencia = diferencia * 2;
            Console.WriteLine($"El doble de la diferencia es: {dobleDiferencia}");
        }
        else
        {
            Console.WriteLine($"El valor absoluto de la diferencia es: {diferencia}");
        }

        Console.ReadLine();
    }
}
