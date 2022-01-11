namespace Pokedex.model;

public abstract class Enemy
{
    public Enemy(string name, Team team, double defeatReward, Item itemDropped)
    {
        Name = name;
        Team = team;
        DefeatReward = defeatReward;
        ItemDropped = itemDropped;
    }

    public Item ItemDropped { get; set; }

    public double DefeatReward { get; set; }

    public Team Team { get; set; }

    public string Name { get; set; }
}