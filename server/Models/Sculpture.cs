namespace art_site.Models;

public class Sculpture
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int? Year { get; set; }
    public int? Price { get; set; }
    public bool? IsLarge { get; set; }
    public string CoverImg { get; set; }
}