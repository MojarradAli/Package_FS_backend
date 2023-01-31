using Microsoft.AspNetCore.Mvc;

namespace Package_FS_API.Controllers;

[Route("instances")]
[ApiController]
public class InstanceController : ControllerBase
{
    private readonly IPositionService _service;

    public InstanceController(IPositionService service)
    {
        _service = service;
    }
    
    [HttpGet("byCount")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<CountInstanceDto>>> CountInstancesAsync()
    {
        var result = await _service.CountInstancesAsync();
        return Ok(result);
    }

    [HttpGet("byPositions")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<PositionInstanceDto>>> PositionInstancesAsync()
    {
        var result = await _service.PositionInstancesAsync();
        return Ok(result);
    }
}
