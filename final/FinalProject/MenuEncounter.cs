public class MenuEncounter : Menu
{
    public MenuEncounter()
    {
        _menuType = "ENCOUNTER GENERATOR";
        _menuOptions =
    @"    1. Start New Encounter
    2. Back";
    }

    public override void RunMenu()
    {
        string choice = HaveUserSelectOption();
        while (choice != "1" && choice != "2")
        {
            choice = HaveUserSelectOption("Invalid Input");
        }
        switch (choice)
        {
            case "1":
                // new MenuForge().HaveUserSelectOption();
                break;
            case "2":
                new MenuGeneral().RunMenu();
                break;
            default:
                break;
        }

    }
}