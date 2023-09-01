namespace SuperAutoCompanies.Companies;

public class SpaceX : Company
{
    public override string Name { get; protected set; }

    public SpaceX(int tier, int damage, int life) : base(tier, damage, life) { }
    public SpaceX()
    {
        Tier = 3;
        Damage = 4;
        Life = 5;
    }
}