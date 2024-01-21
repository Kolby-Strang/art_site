namespace art_site.Repositories;

public class SculpturesRepository
{
    private readonly IDbConnection _db;

    public SculpturesRepository(IDbConnection db)
    {
        _db = db;
    }
}