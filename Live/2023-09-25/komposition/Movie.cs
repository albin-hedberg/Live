namespace Live._2023_09_25;

public class Movie
{
    public Director Director { get; set; }
    public List<Genre> Genre { get; set; } = new List<Genre>();
    public string Name { get; set; }
    public string Description { get; set; }
}
