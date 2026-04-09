public class Character
{
    public string Name { get; set;}
    public string Role {get; set;}
    public int Level {get; set;}
    public int Health { get; set;}
    public int CountOfGold { get; set;}
    public string Status {get; set;}

    public Character(string name, string role, int level, int health,int countOfGold, string status)
    {
        Name = name;
        Role = role;
        Level = level;
        Health = health;
        CountOfGold = countOfGold;
        Status = status;
    }

}