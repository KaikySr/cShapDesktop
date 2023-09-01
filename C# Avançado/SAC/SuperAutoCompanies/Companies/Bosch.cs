namespace SuperAutoCompanies.Companies;

public class Bosch : Company
{
    public override string Name { get; protected set; }

    public Bosch(int tier, int damage, int life) : base(tier, damage, life) { }
    public Bosch()
    {
        Tier = 3;
        Damage = 4;
        Life = 5;
    }
}