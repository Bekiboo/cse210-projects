public abstract class Menu
{
    protected string _menuType;
    protected string _menuOptions;

    public Menu()
    {
    }

    public string HaveUserSelectOption(string message = "")
    {
        Console.Clear();
        Console.WriteLine(_menuType + "         " + message);
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(_menuOptions);
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        return choice;
    }

    public abstract void RunMenu();

}