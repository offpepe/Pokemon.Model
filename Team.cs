namespace Pokedex.model;

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