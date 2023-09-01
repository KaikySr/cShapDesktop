namespace SuperAutoCompanies.Companies;

public abstract class Company
{
    public Company() { }
    public Company(int tier, int damage, int life)
    {
        Tier = tier;
        Damage = damage;
        Life = life;
    }

    protected Company(int level, int exp, int tier, int damage, int life) : this(level, exp, tier)
    {
        Damage = damage;
        Life = life;
    }

    public abstract string Name { get; }
    public int Level { get; protected set; } = 0;
    public int Exp { get; protected set; } = 0;
    public int Tier { get; protected set; }
    public int Damage { get; protected set; }
    public int Life { get; protected set; }
    public virtual void ReceifeDamage(int damage) =>
        Life -= damage;
    public virtual int Attack() =>
        Damage;
}