namespace art_site.Controllers;

public class SculpturesController
{
    private readonly SculpturesService _sculpturesService;

    public SculpturesController(SculpturesService sculpturesService)
    {
        _sculpturesService = sculpturesService;
    }
}