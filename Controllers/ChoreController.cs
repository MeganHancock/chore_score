using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace chore_score.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ChoreController(ChoresService choresService) : ControllerBase
{

    private readonly ChoresService _choresService = choresService;

    [HttpGet]
    public ActionResult<List<Chore>> GetChores()
    {
        try
        {
            List<Chore> chores = _choresService.GetChores();
            return Ok(chores);
        }
        catch (Exception error)
        { return BadRequest(error.Message); };
    }

    [HttpPost]
    public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
    {
        try
        {
            Chore chore = _choresService.CreateChore(choreData);
            return Ok(chore);
        }
        catch (Exception error)
        { return BadRequest(error.Message); }

    }

    // [HttpGet]
    // public ActionResult<string> ApiTest()
    // {
    //     try
    //     {
    //         return Ok("api is up");
    //     }
    //     catch (Exception error)
    //     {
    //         return BadRequest(error.Message);
    //     }
    // }
}