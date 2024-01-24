


using System.Reflection.Metadata.Ecma335;

namespace art_site.Repositories;

public class ImagesRepository
{
    private readonly IDbConnection _db;

    public ImagesRepository(IDbConnection db)
    {
        _db = db;
    }

    internal Image CreateImage(Image imgData)
    {
        string sql = @"
        INSERT INTO images
        (sculptureId, imageUrl)
        VALUES
        (@SculptureId, @ImageUrl);

        SELECT * FROM images
        WHERE id = LAST_INSERT_ID()
        ;";
        Image image = _db.Query<Image>(sql, imgData).FirstOrDefault();
        return image;
    }

    internal void DestroyImageById(int id)
    {
        string sql = @"
        DELETE FROM images
        WHERE id = @Id
        ;";
        _db.Execute(sql, new { id });
    }

    internal Image EditImage(Image imgData)
    {
        string sql = @"
        UPDATE images
        SET
        imageUrl = @ImageUrl,
        sculptureId = @SculptureId
        WHERE id = @Id;

        SELECT * FROM images
        WHERE id = @Id
        ;";
        Image image = _db.Query<Image>(sql, imgData).FirstOrDefault();
        return image;
    }

    internal Image GetImageById(int id)
    {
        string sql = @"
        SELECT * FROM images
        WHERE id = @Id
        ;";
        Image image = _db.Query<Image>(sql, new { id }).FirstOrDefault();
        return image;
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