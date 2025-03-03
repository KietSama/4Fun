using UnityEngine;

public class Team
{
    private int _id;
    private Hero[] _heros;
}

public class TeamsDB
{
    public int ID { get; set; }
    public int HeroID_1st { get; set; }
    public int HeroID_2nd { get; set; }
    public int HeroID_3rd { get; set; }
    public string Account {  get; set; }
}