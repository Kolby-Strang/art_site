namespace art_site.Repositories;

public class SculptureImagesRepository
{
    private readonly IDbConnection _db;

    public SculptureImagesRepository(IDbConnection db)
    {
        _db = db;
    }
}