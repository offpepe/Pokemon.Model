
using System.Threading.Channels;

namespace Pokedex.model;

/// <summary>
/// Gera a classe que descreve um pokemon
/// </summary>
/// <param name="name"> Recebe uma string com o nome do pokemon</param>
/// <param name="weight">Recebe uma string com o peso e a unidade de medida (kg, g, dg e etc)</param>
/// <param name="height">Recebe uma string com a altura e a unidade de medida (m, cm, mm)</param>
/// <param name="habitat">Recebe uma classe do tipo <see cref="Region"/> que descreve o local onde o pokemon habita</param>
/// <param name="envolvesTo">Recebe uma classe do tipo <see cref="Pokemon"/> que descreve a evoluçao deste pokemon</param>
/// <param name="type">Recebe uma string que decreve o tipo do pokemon</param>
/// <param name="moves">recebe um array de strings que descreve os movimentos desse pokemon</param>
/// <param name="atk">Recebe um inteiro com o poder de ataque deste pokemon</param>
/// <param name="def">Recebe um inteiro com a defesa deste pokemon</param>
/// <param name="lfe">Recebe um inteiro com a quantidade de vida deste pokemon</param>
public class Pokemon
{
    private static int _pokeId;
    private int ATK;
    private int DEF;
    private int LFE;

    public static void print() => Console.WriteLine("pokemon");
        
    public Pokemon(string name, string weight, string height, Region habitat, Pokemon? envolvesTo, string type, string[] moves, int atk, int def, int lfe)
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

    public Pokemon? EnvolvesTo { get; set; }

    public Region Habitat { get; }

    public string Height { get; set; }

    public string Weight { get; set; }

    public string Name { get; set; }

    public void Talk() => Console.WriteLine($"{Name}...{Name}..{Name}");

    public string Stats() => $"ATK => {ATK}\nDEF => {DEF}\nLFE => {LFE}"; 

    public void Profile() => Console.WriteLine($"{Name}#{Id} ----> {PokeType}\n" +
                                               $"Height: {Height} | Weight: {Weight}\n" +
                                               $"Habitat -> {Habitat.Name}\n" +
                                               $"ATK ::: {ATK}\n" +
                                               $"DEF ::: {DEF}\n" +
                                               $"LFE ::: {LFE}\n");
    /// <summary>
    /// Faz uma batalha simulada.
    /// </summary>
    /// <param name="opponent"> Deve ser da classe do tipo <see cref="Pokemon"/></param>
    /// <exception cref="ArgumentException">Os pokemons devem ter vida maior que zero</exception>
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

            string winner = BTL_LFE == 0 ? this.Name : opponent.Name;
            Console.WriteLine($"{winner} won!");
        }
        else
        {
            var invalidLife = BTL_LFE > 0 ? opponent.Name : this.Name;
            throw new ArgumentException("O pokemon precisa ter vida maior que 0", invalidLife);
        }
    }

    public void Evolve() {
        if (this.EnvolvesTo != null)
        {
            Console.WriteLine($"TANANANANANANAN > > > > > {Name} have evolved to {EnvolvesTo.Name}");
        }
        else
        {
            Console.WriteLine("Este pokemon não evolui");
        }
    }

}