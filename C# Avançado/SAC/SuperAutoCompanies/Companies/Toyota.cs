namespace SuperAutoCompanies.Companies;

public class Toyota : Company
{
    public override string Name { get; protected set; }

    public Toyota(int tier, int damage, int life) : base(tier, damage, life) { }
    public Toyota()
    {
        Tier = 3;
        Damage = 4;
        Life = 5;
    }
}