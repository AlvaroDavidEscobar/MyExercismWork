abstract class Character {
    private string _character_type;
    protected Character(string character_type) {
        _character_type = character_type;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {_character_type}";
}

class Warrior : Character {
    public Warrior() : base("Warrior") {
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character {
    public bool SpellPrepared = false;
    public Wizard() : base("Wizard") {}

    public override bool Vulnerable() => !SpellPrepared;

    public override int DamagePoints(Character target) => SpellPrepared ? 12 : 3;

    public void PrepareSpell() => SpellPrepared = true;
}
