namespace Pokedex.model;

public class Trainer
{
    public string TrainerID;
    public Trainer(string name, Region startZone, Pokemon[] pokes, Item[] bag, Pokemon pokeComrate)
    {
        Name = name;
        StartZone = startZone;
        Pokes = pokes;
        Bag = bag;
        PokeComrate = pokeComrate;
        TrainerID = Guid.NewGuid().ToString("N");
        
    }
    public Pokemon PokeComrate { get; set; }

    public Item[] Bag { get; set; }

    public Pokemon[] Pokes { get; set; }

    public Region StartZone { get; }

    public string Name { get; set; }
    
    public double Wallet { get; set; }
    
    public void TrainerInfo() => Console.WriteLine($"{TrainerID}\n" +
                                                   $"TRAINER NAME -> {Name}\n" +
                                                   $"START JOURNEY IN {StartZone}\n" +
                                                   $"HAS AS COMRATE {PokeComrate}\n" +
                                                   $"HIS POKES -> {Pokes}");

    public void whatIsAcomrate()
    {
        Pokemon.print();
    }
    
}