namespace SuperAutoCompanies.Companies;

public class CNH : Company
{
    public override string Name { get; protected set; }

    public CNH(int tier, int damage, int life) : base(tier, damage, life) { }
    public CNH()
    {
        Tier = 3;
        Damage = 4;
        Life = 5;
    }
}