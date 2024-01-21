using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace art_site.Controllers;

public class SculpturesController : ControllerBase
{
    private readonly SculpturesService _sculpturesService;

    public SculpturesController(SculpturesService sculpturesService)
    {
        _sculpturesService = sculpturesService;
    }

    [HttpGet]
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
}