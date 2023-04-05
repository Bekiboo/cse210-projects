public class MonsterBeast : Monster
{

    public static int _count = 0;
    public MonsterBeast(
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
        return $"The beast unleashes a ferocious roar, dealing {damage} damage and stunning the target for 1 turn.";
    }

    public override string SpecialAbility()
    {
        return "Pack Tactics: If the beast has an ally within 5ft of its target, it gains advantage on its attack rolls.";
    }
}
