using Realms;

public class HighScore: RealmObject
{
    [PrimaryKey]
    public string Name { get; set; }

    [Required]
    public float LowTime { get; set; } = float.MaxValue;

    public HighScore() { }

    public HighScore(string name, float lowTime)
    {
        Name = name;
        LowTime = lowTime;
    }
}
