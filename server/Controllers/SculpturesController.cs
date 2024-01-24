namespace art_site.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SculpturesController : ControllerBase
{
    private readonly ImagesService _imagesService;
    private readonly SculpturesService _sculpturesService;
    private readonly Auth0Provider _a0;

    public SculpturesController(SculpturesService sculpturesService, Auth0Provider a0, ImagesService imagesService)
    {
        _sculpturesService = sculpturesService;
        _a0 = a0;
        _imagesService = imagesService;
    }

    [HttpGet("small")]
    public ActionResult<List<Sculpture>> GetSmallSculptures()
    {
        try
        {
            List<Sculpture> smallSculptures = _sculpturesService.getSmallSculptures();
            return Ok(smallSculptures);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }
    [HttpGet("large")]
    public ActionResult<List<Sculpture>> GetLargeSculptures()

    {
        try
        {
            List<Sculpture> largeSculptures = _sculpturesService.getLargeSculptures();
            return Ok(largeSculptures);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }
    [HttpGet("{id}")]
    public ActionResult<Sculpture> GetSculptureById(int id)
    {
        try
        {
            Sculpture sculpture = _sculpturesService.GetSculptureById(id);
            return sculpture;
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }
    [HttpPost]
    [Authorize]
    public async Task<ActionResult<Sculpture>> CreateSculpture([FromBody] Sculpture sculptureData)
    {
        try
        {
            Account user = await _a0.GetUserInfoAsync<Account>(HttpContext);
            string userId = user.Id;
            Sculpture sculpture = _sculpturesService.CreateSculpture(sculptureData, userId);
            return Ok(sculpture);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }
    [HttpGet("{id}/images")]
    public ActionResult<List<Image>> GetImagesBySculptureId(int id)
    {
        try
        {
            List<Image> images = _imagesService.GetImagesBySculptureId(id);
            return images;
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }
}