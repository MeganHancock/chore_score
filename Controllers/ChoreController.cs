namespace chore_score.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ChoreController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> ApiTest()
    {
        try
        {
            return Ok("api is up");
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }
}