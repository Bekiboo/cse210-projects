public class MenuGeneral : Menu
{
    public MenuGeneral()
    {
        _menuType = "MAIN MENU";
        _menuOptions =
    @"    1. Monster Forge
    2. Encounter Generator
    3. Quit";
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
                new MenuForge().RunMenu();
                break;
            case "2":
                new MenuEncounter().RunMenu();
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                break;
        }
    }

}