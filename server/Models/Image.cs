namespace art_site.Models;

public class Image
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string ImageUrl { get; set; }
    public int sculptureId { get; set; }
}