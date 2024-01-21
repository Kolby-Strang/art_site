namespace art_site.Controllers;

public class ImagesController
{
    private readonly ImagesService _imagesService;

    public ImagesController(ImagesService imagesService)
    {
        _imagesService = imagesService;
    }
}