class SoccerTeam
{
    public string Team { get; set; }
    public int Points { get; set; }
    public int Ranking { get; set; }
}

class Season
{
    public List<SoccerTeam> Teams { get; }

    public Season()
    {
        Teams = new List<SoccerTeam>();
        ReadSeasonFromFile();
    }

    private void ReadSeasonFromFile()
    {
        string filePath = "mx.1.csv";

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                SoccerTeam team1 = new SoccerTeam();
                team1.Team = fields[2];

                SoccerTeam team2 = new SoccerTeam();
                team2.Team = fields[5];

                Teams.Add(team1);
                Teams.Add(team2);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("El archivo mx.1.csv no se encuentra.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo: " + ex.Message);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Season season = new Season();

        Console.WriteLine("Equipos en la temporada:");
        foreach (SoccerTeam team in season.Teams)
        {
            Console.WriteLine("Equipo: " + team.Team);
        }
    }
}
