namespace Pokedex.model
{
    public abstract class Item
    {
        /// <summary>
        /// Item 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="qtd"></param>
        /// <param name="description"></param>
        /// <param name="recover"></param>
        /// <param name="pts"></param>
        public Item(string name, double price, int qtd, string description, string recover, int pts)
        {
            Name = name;
            Price = price;
            Qtd = qtd;
            Description = description;
            Recover = recover;
            Pts = pts;
        }

        public int Pts { get; set; }

        public string Recover { get; }

        public string Description { get; set; }

        public int Qtd { get; set; }

        public double Price { get; set; }

        public string Name { get; set; }

        public void ItemInfo() => Console.WriteLine($"{Name} ==> {Qtd}\n" +
                                                    $"CUSTO => ${Price}\n" +
                                                    $"Description: {Description}");

        public virtual void Use(Pokemon target)
        {
        
        }
        public void Discard(int qtd) => Qtd -= qtd;
    
        public void Sell(int qtd, Trainer trainer)
        {
            this.Qtd -= qtd;
            trainer.Wallet += (Price * qtd) * 0.9;
        }

    }
}

