public class MonsterDragon : Monster
{

    public static int _count = 0;
    public MonsterDragon(
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
        return $"The dragon breathes fire in a 15ft cone, dealing {damage} damage";
    }

    public override string SpecialAbility()
    {
        return "Fly";
    }
}
