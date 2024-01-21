namespace art_site.Controllers;

public class SculptureImagesController
{
    private readonly SculptureImagesService _sculptureImagesService;

    public SculptureImagesController(SculptureImagesService sculptureImagesService)
    {
        _sculptureImagesService = sculptureImagesService;
    }
}