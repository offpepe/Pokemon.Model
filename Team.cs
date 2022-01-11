namespace Pokedex.model;

    /// <summary> Cria uma classe do tipo TIME. </summary>
    /// <summary name="name">Recebe uma string que carrega o nome do time</summary>
    /// <summary name="leader">Recebe uma outra classe do tipo <see cref="Enemy"/>, pois os times são estritamente para inimigos, que carrega o lider deste time</summary>
    /// <summary name="allocatedIn">Recebe uma outra classe do tipo <see cref="Region"/> que carrega a região onde o time está instalado</summary>
public class Team
{
public Team(string name, Enemy leader, Region allocatedIn)
    {
        Name = name;
        Leader = leader;
        AllocatedIn = allocatedIn;
    }

    public Region AllocatedIn { get; set; }

    public Enemy Leader { get; set; }

    public string Name { get; set; }
}