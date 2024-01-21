
namespace art_site.Repositories;

public class SculpturesRepository
{
    private readonly IDbConnection _db;

    public SculpturesRepository(IDbConnection db)
    {
        _db = db;
    }

    internal List<Sculpture> getSmallSculptures()
    {
        string sql = @"
        ";

        List<Sculpture> smallSculptures = _db.Query<Sculpture>(sql).ToList();
        // TODO left off here

        return smallSculptures;
    }
}