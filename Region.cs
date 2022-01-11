namespace Pokedex.model;

public class Region
{
    private static int _id;
    public Region(string name, string[] settlements, int population)
    {
        Name = name;
        Settlements = settlements;
        Population = population;
        _id += 1;
        Id = _id;
    }

    public int Id { get; }

    public int Population { get; set; }

    public string[] Settlements { get; set; }

    public string Name { get; set; }
}