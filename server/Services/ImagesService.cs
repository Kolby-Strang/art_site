

namespace art_site.Services;

public class ImagesService
{
    private readonly ImagesRepository _repo;

    public ImagesService(ImagesRepository repo)
    {
        _repo = repo;
    }

    internal string CreateImage(Image imgData, string userId)
    {

    }

    internal List<Image> GetImagesBySculptureId(int id)
    {
        List<Image> images = _repo.GetImagesBySculptureId(id);
        return images;
    }
}