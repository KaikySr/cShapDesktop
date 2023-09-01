namespace SuperAutoCompanies.Companies;

public class Microsoft : Company
{
    public override string Name { get; protected set; }

    public Microsoft(int tier, int damage, int life) : base(tier, damage, life) { }
    public Microsoft()
    {
        Tier = 3;
        Damage = 4;
        Life = 5;
    }
}