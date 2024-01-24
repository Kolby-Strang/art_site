using Microsoft.Extensions.Configuration.UserSecrets;

namespace art_site.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ImagesController : ControllerBase
{
    private readonly ImagesService _imagesService;
    private readonly Auth0Provider _a0;

    public ImagesController(ImagesService imagesService, Auth0Provider a0)
    {
        _imagesService = imagesService;
        _a0 = a0;
    }
    [HttpPut("{id}")]
    [Authorize]
    public async Task<ActionResult<Image>> EditImage([FromBody] Image imgData, int id)
    {
        try
        {
            Account user = await _a0.GetUserInfoAsync<Account>(HttpContext);
            string userId = user.Id;
            Image image = _imagesService.EditImage(id, imgData, userId);
            return Ok(image);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<ActionResult<String>> DestroyImageById(int id)
    {
        try
        {
            Account user = await _a0.GetUserInfoAsync<Account>(HttpContext);
            string userId = user.Id;
            string message = _imagesService.DestroyImageById(id, userId);
            return Ok(message);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }
}