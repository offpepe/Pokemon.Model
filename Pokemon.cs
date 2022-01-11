
using System.Threading.Channels;

namespace Pokedex.model;

public class Pokemon
{
    private static int _pokeId;
    private int ATK;
    private int DEF;
    private int LFE;

    public Pokemon(string name, string weight, string height, Region habitat, Pokemon envolvesTo, string type, string[] moves, int atk, int def, int lfe)
    {
        Name = name;
        Weight = weight;
        Height = height;
        Habitat = habitat;
        EnvolvesTo = envolvesTo;
        Moves = moves;
        PokeType = type;
        _pokeId += 1;
        Id = _pokeId;
        ATK = atk;
        DEF = def;
        LFE = lfe;
    }

    public string PokeType { get; }

    public string[] Moves { get; set; }

    public int Id { get; }

    public Pokemon EnvolvesTo { get; set; }

    public Region Habitat { get; }

    public string Height { get; set; }

    public string Weight { get; set; }

    public string Name { get; set; }

    public void Talk() => Console.WriteLine($"{Name}...{Name}..{Name}");

    public void Profile() => Console.WriteLine($"{Name}#{Id}[EVO:::{EnvolvesTo.Name} ----> {PokeType}\n" +
                                               $"Height: {Height} | Weight: {Weight}\n" +
                                               $"Habitat -> {Habitat.Name}" +
                                               $"ATK ::: {ATK}\n" +
                                               $"DEF ::: {DEF}\n" +
                                               $"LFE ::: {LFE}\n" +
                                               $"MOVES ==> {Moves}");

    public void BasicBattle(Pokemon opponent)
    {
        int BTL_LFE = this.LFE;
        int OPT_LFE = opponent.LFE;
        if (BTL_LFE > 0 || OPT_LFE > 0)
        {
            do
            {
                OPT_LFE -= ATK - opponent.DEF; 
                BTL_LFE -= opponent.ATK - DEF;
            } while (BTL_LFE > 0 || OPT_LFE > 0);

            string winner = BTL_LFE == 0 ? opponent.Name : this.Name;
            Console.WriteLine($"{winner} won!");
        }
        else
        {
            Console.WriteLine($"Some pokemon can't battle, go to the near poke clinic...");
        }
    }

    public void Evolve() => Console.WriteLine($"TANANANANANANAN > > > > > {Name} have evolved to {EnvolvesTo.Name} ");

}