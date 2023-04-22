public class Student : Person
{
    public string grade {get;set;}

    public void SetCountry (string country)
    {
        this.Country = country;
    }

    public void SetCountry ()
    {
        Console.WriteLine(this.Country);
    }
}

