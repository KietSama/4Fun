using UnityEngine;

public class Hero
{
    private int _id;
    private string _name;
    private Skill[] _skills;
    private HeroType _heroType;

    public int ID { get { return _id; } set { _id = value; } }
    public string Name { get { return _name; } set { _name = value; } }
    public Skill[] Skills { get { return _skills; } }
    public HeroType HeroType { get { return _heroType; } set { _heroType = value; } }

    public Hero()
    {
        ID = -1;
        Name = "";
        _skills = new Skill[3];
        HeroType = new HeroType();
    }

    public Hero(int id, string name, Skill[] skills, HeroType type)
    {
        ID = id;
        Name = name;
        HeroType = type;
        _skills = new Skill[3];

        if (skills != null && skills.Length >= 3)
        {
            _skills[0] = skills[0];
            _skills[1] = skills[1];
            _skills[2] = skills[2];
        }
    }

    public void SetSkill(int index, Skill skill)
    {
        if (_skills == null || _skills.Length == 0)
            _skills = new Skill[3];

        if(index >= 0 && index < Skills.Length)
        {
            _skills[index] = skill;
        }
    }
}

public class HeroType
{
    public int ID { get; set; }
    public TypeEnum Type { get; set; }


    public HeroType()
    {
        ID = -1;
        Type = TypeEnum.Normal;
    }

    public enum TypeEnum
    {
        Normal,
        SP,
        PK,
    }
}

public class HerosDB
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Skill01 { get; set; }
    public int Skill02 { get; set; }
    public int Skill03 { get; set; }
    public string Type { get; set; }
}