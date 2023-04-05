public abstract class Monster
{
    private static Monster[] _monsterList { get; set; }
    private string _type { get; }
    private string _name { get; }
    private string _description { get; }
    private int _health { get; set; }
    private int _maxHealth { get; }
    protected int _attack { get; }
    private int _defense { get; }



    public Monster(string name, string description, int health, int attack, int defense)
    {
        _name = name;
        _description = description;
        _health = health;
        _attack = attack;
        _defense = defense;
        _maxHealth = health;
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

    public string GetMonsterName()
    {
        return _name;
    }

    public string GetMonsterDescription()
    {
        return _description;
    }

    public int GetMonsterHealth()
    {
        return _health;
    }

    public int GetMonsterAttack()
    {
        return _attack;
    }

    public int GetMonsterDefense()
    {
        return _defense;
    }

    public int GetMonsterMaxHealth()
    {
        return _maxHealth;
    }

    public void SetMonsterHealth(int health)
    {
        _health = health;
    }



    public static Monster GetRandomMonster()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _monsterList.Length);

        return _monsterList[randomIndex];
    }

    public abstract object SpecialAttack();
    public abstract string SpecialAbility();
}