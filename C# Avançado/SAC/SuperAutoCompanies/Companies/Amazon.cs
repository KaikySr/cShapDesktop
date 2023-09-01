namespace SuperAutoCompanies.Companies;

public class Amazon : Company
{
	public override string Name { get; protected set; }

	public Amazon(int tier, int damage, int life) : base(tier, damage, life) { }
    public Amazon()
    {
        Tier = 3;
        Damage = 4;
        Life = 5;
    }
}