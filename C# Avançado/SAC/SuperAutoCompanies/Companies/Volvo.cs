namespace SuperAutoCompanies.Companies;

public class Volvo : Company
{
    public override string Name { get; protected set; }

    public Volvo(int tier, int damage, int life) : base(tier, damage, life) { }
    public Volvo() 
    {
        Tier = 3;
        Damage = 4;
        Life = 5;
    }
}