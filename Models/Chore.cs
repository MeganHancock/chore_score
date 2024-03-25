namespace chore_score.Models;

public class Chore
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int lengthInMinutes { get; set; }
    public bool requiresChemical { get; set; }
    public bool completed { get; set; }
}