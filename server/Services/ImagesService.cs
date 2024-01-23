namespace art_site.Services;

public class ImagesService
{
    private readonly ImagesRepository _repo;

    public ImagesService(ImagesRepository repo)
    {
        _repo = repo;
    }
}