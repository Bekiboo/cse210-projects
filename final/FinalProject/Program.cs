class Program
{
    static void Main(string[] args)
    {
        MonsterSkulker monster1 = new MonsterSkulker("Goblin", "A small green creature", 10, 5, 5);
        Monster.AddMonsterToList(monster1);
        MonsterBeast monster2 = new MonsterBeast("Orc", "A brutish humanoid with tusk-like teeth", 20, 10, 10);
        Monster.AddMonsterToList(monster2);
        MonsterBeast monster3 = new MonsterBeast("Troll", "A large, regenerating creature with a tough hide", 30, 15, 15);
        Monster.AddMonsterToList(monster3);
        MonsterBeast monster4 = new MonsterBeast("Giant", "An enormous humanoid with immense strength", 40, 20, 20);
        Monster.AddMonsterToList(monster4);
        MonsterDragon monster5 = new MonsterDragon("Red Dragon", "A massive dragon with red scales and fiery breath", 50, 25, 25);
        Monster.AddMonsterToList(monster5);
        MonsterDragon monster6 = new MonsterDragon("Black Dragon", "A massive dragon with black scales and acidic breath", 60, 30, 30);
        Monster.AddMonsterToList(monster6);
        MonsterDragon monster7 = new MonsterDragon("White Dragon", "A massive dragon with white scales and freezing breath", 70, 35, 35);
        Monster.AddMonsterToList(monster7);
        MonsterUndead monster8 = new MonsterUndead("Zombie", "A reanimated corpse", 80, 40, 40);
        Monster.AddMonsterToList(monster8);
        MonsterUndead monster9 = new MonsterUndead("Skeleton", "A reanimated skeleton", 90, 45, 45);
        Monster.AddMonsterToList(monster9);
        MonsterUndead monster10 = new MonsterUndead("Ghoul", "A malevolent undead with sharp claws", 100, 50, 50);
        Monster.AddMonsterToList(monster10);
        MonsterElemental monster11 = new MonsterElemental("Fire Elemental", "A fiery creature made of living flames", 110, 55, 55);
        Monster.AddMonsterToList(monster11);
        MonsterElemental monster12 = new MonsterElemental("Water Elemental", "A watery creature with the power to manipulate water", 120, 60, 60);
        Monster.AddMonsterToList(monster12);
        MonsterElemental monster13 = new MonsterElemental("Earth Elemental", "A rocky creature with the power to manipulate earth", 130, 65, 65);
        Monster.AddMonsterToList(monster13);
        MonsterElemental monster14 = new MonsterElemental("Air Elemental", "A gusty creature with the power to manipulate air", 140, 70, 70);
        Monster.AddMonsterToList(monster14);
        MonsterElemental monster15 = new MonsterElemental("Lightning Elemental", "A crackling creature with the power to manipulate lightning", 150, 75, 75);
        Monster.AddMonsterToList(monster15);
        MonsterElemental monster16 = new MonsterElemental("Ice Elemental", "A freezing creature with the power to manipulate ice", 160, 80, 80);
        Monster.AddMonsterToList(monster16);


        new MenuGeneral().RunMenu();
    }
}