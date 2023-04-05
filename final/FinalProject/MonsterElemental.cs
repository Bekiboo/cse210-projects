public class MonsterElemental : Monster
{

    public static int _count = 0;
    public MonsterElemental(
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
        return $"The elemental unleashes a burst of energy, dealing {damage} damage to all enemies.";
    }

    public override string SpecialAbility()
    {
        return "Phase Shift: The elemental becomes incorporeal and gains resistance to all damage for 1 turn.";
    }
}
