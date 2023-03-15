// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using System;

public class Casa
{
    private double area;
    private Puerta door;

    public Casa(double area)
    {
        this.area = area;
        door = new Puerta();
    }

    public double Area
    {
        get { return area; }
        set { area = value; }
    }

    public Puerta Door
    {
        get { return door; }
        set { door = value; }
    }

    public void ShowData()
    {
        Console.WriteLine($"Soy una casa, mi área es de {area} m2");
    }

    public Puerta GetDoor()
    {
        return door;
    }
}

public class Puerta
{
    private string color;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public void ShowData()
    {
        Console.WriteLine($"Soy una puerta, mi color es {color}");
    }
}

public class PequeñoApartamento : Casa
{
    public PequeñoApartamento() : base(50)
    {
    }
}

public class Persona
{
    private string nombre;
    private Casa casa;

    public Persona(string nombre, Casa casa)
    {
        this.nombre = nombre;
        this.casa = casa;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public Casa Casa
    {
        get { return casa; }
        set { casa = value; }
    }

    public void ShowData()
    {
        Console.WriteLine($"Nombre: {nombre}");
        casa.ShowData();
        casa.GetDoor().ShowData();
    }
}
