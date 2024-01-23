namespace art_site.Services;

public class SculptureImagesService
{
    private readonly SculptureImagesRepository _repo;

    public SculptureImagesService(SculptureImagesRepository repo)
    {
        _repo = repo;
    }
}