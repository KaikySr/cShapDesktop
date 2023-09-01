namespace SuperAutoCompanies.Companies;

public class Reanult : Company
{
    public override string Name { get; protected set; }

    public Renault(int tier, int damage, int life) : base(tier, damage, life) { }
    public Renault()
    {
        Tier = 3;
        Damage = 4;
        Life = 5;
    }
}