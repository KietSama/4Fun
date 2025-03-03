using UnityEngine;

public class Skill
{
    private int _id;
    private string _name;
    private string _description;
    private SkillType _skillType;
    private Hero _hero;

    public int ID { get { return _id; } set { _id = value; } }
    public string Name { get { return _name; } set { _name = value; } }
    public string Description { get { return _description; } set { _description = value; } }
    public SkillType SkillType { get { return _skillType; } set { _skillType = value; } }
    public Hero Hero { get { return _hero; } set { _hero = value; } }

    public Skill()
    {
        ID = -1;
        Name = string.Empty;
        Description = string.Empty;
        SkillType = new SkillType();
        Hero = new Hero();
    }

    public Skill(int id, string name, string description, SkillType skillType, Hero hero)
    {
        ID = id;
        Name = name;
        Description = description;
        SkillType = skillType;
        Hero = hero;
    }
}

public class SkillType
{
    public int ID { get; set; }
    public TypeEnum Type { get; set; }

    public SkillType()
    {
        ID = -1;
        Type = TypeEnum.C;
    }

    public enum TypeEnum
    {
        S, A, B, C
    }
}

public class SkillsDB
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public int HeroID { get; set; }
}