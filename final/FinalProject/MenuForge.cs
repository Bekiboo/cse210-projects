public class MenuForge : Menu
{
    public MenuForge()
    {
        _menuType = "FORGE";
        _menuOptions =
    @"    1. Display Monsters
    2. Create New Monsters
    3. Back";
    }

    private void DisplayMonsters()
    {
        Console.Clear();
        Console.WriteLine("MONSTERS");
        Console.WriteLine();
        Console.WriteLine(Monster.GetMonsterListAsString());
        Console.WriteLine();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        new MenuForge().RunMenu();
    }


    public override void RunMenu()
    {
        string choice = HaveUserSelectOption();
        while (choice != "1" && choice != "2" && choice != "3")
        {
            choice = HaveUserSelectOption("Invalid Input");
        }
        switch (choice)
        {
            case "1":
                DisplayMonsters();
                break;
            case "2":
                new MenuMonster().RunMenu();
                break;
            case "3":
                new MenuGeneral().RunMenu();
                break;
            default:
                break;
        }
        choice = HaveUserSelectOption();
    }

}