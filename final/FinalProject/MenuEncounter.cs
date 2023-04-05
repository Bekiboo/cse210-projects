public class MenuEncounter : Menu
{
    Monster _monster;
    public MenuEncounter()
    {
        _monster = Monster.GetRandomMonster();

        _menuType =
$@"You have encountered a {_monster.GetMonsterName()}!
Description: {_monster.GetMonsterDescription()}
Health: {_monster.GetMonsterHealth()}/{_monster.GetMonsterMaxHealth()}
Attack: {_monster.GetMonsterAttack()}
Defense: {_monster.GetMonsterDefense()}";

        _menuOptions =
@"1. Have the monster use its special ability
2. Have the monster use its attack
3. Damage the monster
4. Run away";
    }


    public override void RunMenu()
    {
        string choice = HaveUserSelectOption();
        while (choice != "1" && choice != "2" && choice != "3" && choice != "4")
        {
            choice = HaveUserSelectOption("Invalid Input");
        }
        while (choice != "4")
        {

            string message = "";

            switch (choice)
            {
                case "1":
                    message = _monster.GetMonsterName() + " used its special ability: " + _monster.SpecialAbility();
                    break;
                case "2":
                    message = _monster.GetMonsterName() + " used its attack: " + _monster.SpecialAttack();
                    break;
                case "3":
                    Console.WriteLine("How much damage do you want to do?");
                    int damage = Convert.ToInt32(Console.ReadLine());
                    Console.ReadLine();
                    _monster.SetMonsterHealth(_monster.GetMonsterHealth() - damage);
                    message = _monster.GetMonsterName() + " took " + damage + " damage! It has " + _monster.GetMonsterHealth() + " health left over " + _monster.GetMonsterMaxHealth();
                    break;
                case "4":
                    new MenuGeneral().RunMenu();
                    break;
                default:
                    break;
            }
            choice = HaveUserSelectOption(message);
        }
    }
}