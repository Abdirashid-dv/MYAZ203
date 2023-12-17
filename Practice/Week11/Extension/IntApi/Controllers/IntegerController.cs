using IntLib;
using Microsoft.AspNetCore.Mvc;

namespace IntApi.Controllers;

[ApiController]
[Route("[controller]")]

public class IntegerController : ControllerBase
{
    [HttpGet("until/{number}")]
    public IActionResult GetUntilNumber(int number)
    {
        return Ok(IntOpetation.UntilNumber(number));
    }
}