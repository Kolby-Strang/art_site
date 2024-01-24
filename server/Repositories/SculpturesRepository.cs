





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
        SELECT * FROM sculptures
        WHERE sculptures.isLarge = false
        ;";

        List<Sculpture> smallSculptures = _db.Query<Sculpture>(sql).ToList();
        return smallSculptures;
    }
    internal List<Sculpture> getLargeSculptures()
    {
        string sql = @"
        SELECT * FROM sculptures
        WHERE sculptures.isLarge = true
        ;";

        List<Sculpture> largeSculptures = _db.Query<Sculpture>(sql).ToList();
        return largeSculptures;
    }

    internal Sculpture CreateSculpture(Sculpture sculptureData)
    {
        string sql = @"
        INSERT INTO sculptures
        (name, description, year, price, isLarge, coverImg)
        VALUES
        (@Name, @Description, @Year, @Price, @IsLarge, @CoverImg);

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