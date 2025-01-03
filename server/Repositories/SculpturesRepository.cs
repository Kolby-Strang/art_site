





namespace art_site.Repositories;

public class SculpturesRepository
{
    private readonly IDbConnection _db;

    public SculpturesRepository(IDbConnection db)
    {
        _db = db;
    }

    internal List<Sculpture> getSculptures()
    {
        string sql = @"
        SELECT * FROM sculptures
        ORDER BY order
        ;";

        List<Sculpture> sculptures = _db.Query<Sculpture>(sql).ToList();
        return sculptures;
    }

    internal Sculpture CreateSculpture(Sculpture sculptureData)
    {
        string sql = @"
        INSERT INTO sculptures
        (name, description, year, price, isLarge, coverImg, dimensions)
        VALUES
        (@Name, @Description, @Year, @Price, @IsLarge, @CoverImg, @Dimensions);

        SELECT * FROM sculptures
        WHERE id = LAST_INSERT_ID()
        ;";
        Sculpture sculpture = _db.Query<Sculpture>(sql, sculptureData).FirstOrDefault();
        return sculpture;
    }

    internal Sculpture GetSculptureById(int id)
    {
        string sql = @"
        SELECT * FROM sculptures
        WHERE id = @Id
        ;";
        Sculpture sculpture = _db.Query<Sculpture>(sql, new { id }).FirstOrDefault();
        return sculpture;
    }

    internal Sculpture EditSculpture(Sculpture sculptureData)
    {
        string sql = @"
        UPDATE sculptures
        SET
        year = @Year,
        isLarge = @IsLarge,
        price = @Price,
        coverImg = @CoverImg,
        description = @Description,
        dimensions = @Dimensions,
        name = @Name
        WHERE id = @Id;

        SELECT * FROM sculptures
        WHERE id = @Id
        ;";
        Sculpture sculpture = _db.Query<Sculpture>(sql, sculptureData).FirstOrDefault();
        return sculpture;
    }

    internal void DestroySculptureById(int id)
    {
        string sql = @"
        DELETE FROM sculptures
        WHERE id = @Id;
        ;";
        _db.Execute(sql, new { id });
    }
}