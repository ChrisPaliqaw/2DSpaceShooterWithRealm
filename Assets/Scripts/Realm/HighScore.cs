using Realms;

public class HighScore: RealmObject
{
    [PrimaryKey]
    public string Name { get; set; }

    public int Score { get; set; } = 0;

    public HighScore() { }

    public HighScore(string name)
    {
        Name = name;
    }
}
