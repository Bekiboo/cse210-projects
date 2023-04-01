public abstract class Monster
{
    private static Monster[] _monsterList { get; set; }
    private string _type { get; }
    private string _name { get; }
    private string _description { get; }
    private int _health { get; set; }
    protected int _attack { get; }
    private int _defense { get; }
    private int _powerLevel { get; }



    public Monster(string name, string description, int health, int attack, int defense, int powerLevel)
    {
        _name = name;
        _description = description;
        _health = health;
        _attack = attack;
        _defense = defense;
        _powerLevel = powerLevel;
    }

    public static void AddMonsterToList(Monster newMonster)
    {
        if (_monsterList == null)
        {
            _monsterList = new Monster[] { newMonster };
        }
        else
        {
            Monster[] newMonsterList = new Monster[_monsterList.Length + 1];

            for (int i = 0; i < _monsterList.Length; i++)
            {
                newMonsterList[i] = _monsterList[i];
            }

            newMonsterList[newMonsterList.Length - 1] = newMonster;

            _monsterList = newMonsterList;
        }
    }

    public static Monster[] GetMonsterList()
    {
        return _monsterList;
    }

    public static string GetMonsterListAsString()
    {
        string monsterList = "";

        foreach (Monster monster in _monsterList)
        {
            monsterList += monster._type + " - " + monster._name + " - " + monster._description + "\n";
        }

        return monsterList;
    }

    public static Monster GetRandomMonsterByPowerlevel(int powerLevel)
    {
        Monster[] monstersByPowerLevel = new Monster[_monsterList.Length];
        int count = 0;

        foreach (Monster monster in _monsterList)
        {
            if (monster._powerLevel == powerLevel)
            {
                monstersByPowerLevel[count] = monster;
                count++;
            }
        }

        Random random = new Random();
        int randomIndex = random.Next(0, monstersByPowerLevel.Length);

        return monstersByPowerLevel[randomIndex];
    }

    public abstract object SpecialAttack();
    public abstract string SpecialAbility();
}