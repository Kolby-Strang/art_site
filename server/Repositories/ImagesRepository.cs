
namespace art_site.Repositories;

public class ImagesRepository
{
    private readonly IDbConnection _db;

    public ImagesRepository(IDbConnection db)
    {
        _db = db;
    }

    internal List<Image> GetImagesBySculptureId(int id)
    {
        string sql = @"
        SELECT * FROM images
        WHERE sculptureId = @Id
        ;";
        List<Image> images = _db.Query<Image>(sql, new { id }).ToList();
        return images;
    }
}