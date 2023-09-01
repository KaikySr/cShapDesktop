namespace SuperAutoCompanies.Companies;

public class Apple : Company
{
    public override string Name { get; protected set; }

    public Apple(int tier, int damage, int life) : base(tier, damage, life) { }
    public Apple()
    {
        Tier = 3;
        Damage = 4;
        Life = 5;
    }
}