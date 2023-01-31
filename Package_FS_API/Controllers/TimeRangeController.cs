using Microsoft.AspNetCore.Mvc;

namespace Package_FS_API.Controllers;

[Route("timeRange")]
[ApiController]
public class TimeRangeController : ControllerBase
{
    private readonly ITimeRangeService _service;

    public TimeRangeController(ITimeRangeService service)
    {
        _service = service;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<TimeRangeDto>> GetRange()
    {
        var result = await _service.GetAsync();
        return Ok(result);
    }
}
