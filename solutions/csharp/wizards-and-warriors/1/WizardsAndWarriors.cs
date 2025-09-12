abstract class Character
{
    private string characterType;
    
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior") {}

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    private bool prepared = false;
    
    public Wizard() : base("Wizard") {}

    public override int DamagePoints(Character target) => prepared ? 12 : 3;

    public void PrepareSpell() => this.prepared = true;

    public override bool Vulnerable() => !this.prepared;
}
