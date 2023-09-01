namespace SuperAutoCompanies.Companies;

public class Volkswagem : Company
{
    public override string Name { get; protected set; }

    public Volkswagem(int tier, int damage, int life) : base(tier, damage, life) { }
    public Volkswagem()
    {
        Tier = 3;
        Damage = 4;
        Life = 5;
    }
}