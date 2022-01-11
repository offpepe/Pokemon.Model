namespace Pokedex.model;

public class Pokemon
{
    private static int _pokeId;
    public Pokemon(string name, string weight, string height, string habitat, Pokemon envolvesTo)
    {
        Name = name;
        Weight = weight;
        Height = height;
        Habitat = habitat;
        EnvolvesTo = envolvesTo;
        _pokeId += 1;
        Id = _pokeId;
    }

    public Pokemon EnvolvesTo { get; set; }

    public string Habitat { get; set; }

    public string Height { get; set; }

    public string Weight { get; set; }

    public string Name { get; set; }
    
    
}