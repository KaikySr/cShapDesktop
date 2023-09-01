namespace SuperAutoCompanies.Companies;

public class Meta : Company
{
    public override string Name { get; protected set; }

    public Meta(int tier, int damage, int life) : base(tier, damage, life) { }
    public Meta()
    {
        Tier = 3;
        Damage = 4;
        Life = 5;
    }
}