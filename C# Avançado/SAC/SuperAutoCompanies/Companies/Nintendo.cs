namespace SuperAutoCompanies.Companies;

public class Nintendo : Company
{
    public override string Name { get; } = "Nintendo";

    public Nintendo(int tier, int damage, int life) : base(tier, damage, life) { }
    public Nintendo()
    {
        Tier = 1;
        Damage = 2;
        Life = 3;
    }
}