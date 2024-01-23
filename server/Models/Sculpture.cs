namespace art_site.Models;

public class Sculpture
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public bool IsLarge { get; set; }
    public List<string> Images { get; set; }
}