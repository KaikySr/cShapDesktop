namespace SuperAutoCompanies.Companies;

public class Sony : Company
{
    public override string Name { get; protected set; }

    public Sony(int tier, int damage, int life) : base(tier, damage, life) { }
    public Sony()
    {
        Tier = 3;
        Damage = 4;
        Life = 5;
    }
}