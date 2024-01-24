
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
        throw new NotImplementedException();
    }
}