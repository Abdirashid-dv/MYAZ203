using Microsoft.AspNetCore.Mvc;
using StringLib;

namespace StringApi.Controllers;


[ApiController]
[Route("api/[controller]")]


public class StringLibController : ControllerBase
{
    [HttpPost]
    public IActionResult GetNumOfSpaces(string input)
    {
        return Ok(new
        {
            numberOfSpaces = input.NumOfSpaces()
        });
    }

}