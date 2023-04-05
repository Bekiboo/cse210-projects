public class MonsterUndead : Monster
{

    public static int _count = 0;
    public MonsterUndead(
        string name,
        string description,
        int health,
        int attack,
        int defense
    )
        : base(name, description, health, attack, defense)
    {

    }

    public override string SpecialAttack()
    {
        Random rand = new Random();
        int damage = rand.Next(_attack / 2, _attack * 2);
        return $"The undead creature lets out a terrifying scream, causing all enemies within 30ft to make a Wisdom saving throw or be frightened for 1 minute.";
    }

    public override string SpecialAbility()
    {
        return "Undead Fortitude: If the undead creature would be reduced to 0 hit points, it instead has a chance to remain at 1 hit point (DC = 5 + damage taken).";
    }
}
