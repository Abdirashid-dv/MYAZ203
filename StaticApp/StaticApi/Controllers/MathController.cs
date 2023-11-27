using Microsoft.AspNetCore.Mvc;
using StaticApi.Models;

namespace StaticApi.Controllers
{
    [ApiController]
    [Route("api/math")]
    public class MathController : ControllerBase
    {

        [HttpPost("/Add")]
        public IActionResult Add(Input input)
        {
            var output = new Output();
            output.Result = Mathlib.MathHelper.Add(input.x, input.y);
            return Ok(output);
        }

        [HttpPost("/Sub")]
        public IActionResult Sub(Input input)
        {
            var output = new Output();
            output.Result = Mathlib.MathHelper.Substract(input.x, input.y);
            return Ok(output);
        }

        [HttpPost("/Mult")]
        public IActionResult Mult(Input input)
        {
            var output = new Output();
            output.Result = Mathlib.MathHelper.Multiplication(input.x, input.y);
            return Ok(output);
        }

        [HttpPost("/Div")]
        public IActionResult Division(Input input)
        {
            var output = new Output();
            output.Result = Mathlib.MathHelper.Division(input.x, input.y);
            return Ok(output);
        }


    }
}
