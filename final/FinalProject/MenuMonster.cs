public class MenuMonster : Menu
{
    public MenuMonster()
    {
        _menuType = "Choose a Monster Type";
        _menuOptions =
    @"    1. Beast
    2. Dragon
    3. Elemental
    4. Skulker
    5. Undead";
    }

    private void CreateMonster(string type)
    {
        Console.WriteLine("Enter the name of the monster");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the description of the monster");
        string description = Console.ReadLine();
        Console.WriteLine("Enter the health of the monster");

        int health;
        while (!int.TryParse(Console.ReadLine(), out health))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }

        Console.WriteLine("Enter the attack of the monster");
        int attack;
        while (!int.TryParse(Console.ReadLine(), out attack))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }

        Console.WriteLine("Enter the defense of the monster");
        int defense;
        while (!int.TryParse(Console.ReadLine(), out defense))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }

        Console.WriteLine("Enter the speed of the monster");
        int speed;
        while (!int.TryParse(Console.ReadLine(), out speed))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }

        Console.WriteLine("Enter the power level of the monster");
        int powerLevel;
        while (!int.TryParse(Console.ReadLine(), out powerLevel))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }

        switch (type)
        {
            case "1":
                MonsterBeast monster = new MonsterBeast(name, description, health, attack, defense);
                Monster.AddMonsterToList(monster);
                break;
            case "2":
                MonsterDragon monster2 = new MonsterDragon(name, description, health, attack, defense);
                Monster.AddMonsterToList(monster2);
                break;
            case "3":
                MonsterElemental monster3 = new MonsterElemental(name, description, health, attack, defense);
                Monster.AddMonsterToList(monster3);
                break;
            case "4":
                MonsterSkulker monster4 = new MonsterSkulker(name, description, health, attack, defense);
                Monster.AddMonsterToList(monster4);
                break;
            case "5":
                MonsterUndead monster5 = new MonsterUndead(name, description, health, attack, defense);
                Monster.AddMonsterToList(monster5);
                break;
        }
    }

    public override void RunMenu()
    {
        string choice = HaveUserSelectOption();
        while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
        {
            choice = HaveUserSelectOption("Invalid Input");
        }
        switch (choice)
        {
            case "1":
                CreateMonster(choice);
                break;
            case "2":
                CreateMonster(choice);
                break;
            case "3":
                CreateMonster(choice);
                break;
            case "4":
                CreateMonster(choice);
                break;
            case "5":
                CreateMonster(choice);
                break;
            default:
                break;
        }
        new MenuForge().RunMenu();
    }

}