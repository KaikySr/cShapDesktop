namespace SuperAutoCompanies.Companies;

public class Samsung : Company
{
    public override string Name { get; protected set; }

    public Samsung(int tier, int damage, int life) : base(tier, damage, life) { }
    public Samsung()
    {
        Tier = 3;
        Damage = 4;
        Life = 5;
    }
}