namespace art_site.Controllers;

public class SculptureImagesController : ControllerBase
{
    private readonly SculptureImagesService _sculptureImagesService;

    public SculptureImagesController(SculptureImagesService sculptureImagesService)
    {
        _sculptureImagesService = sculptureImagesService;
    }
}