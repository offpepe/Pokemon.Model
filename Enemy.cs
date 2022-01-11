namespace Pokedex.model;

public abstract class Enemy
{
    public Enemy(string name, string team, double defeatReward, Item itemDropped)
    {
        Name = name;
        Team = team;
        DefeatReward = defeatReward;
        ItemDropped = itemDropped;
    }

    public Item ItemDropped { get; set; }

    public double DefeatReward { get; set; }

    public string Team { get; set; }

    public string Name { get; set; }
}