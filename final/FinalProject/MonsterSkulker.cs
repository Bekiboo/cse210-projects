public class MonsterSkulker : Monster
{

    public static int _count = 0;
    public MonsterSkulker(
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
        return $"The skulker disappears from sight and reappears behind its target, dealing {damage} damage.";
    }

    public override string SpecialAbility()
    {
        return "Evasion: The skulker can use its reaction to dodge an incoming attack.";
    }
}
