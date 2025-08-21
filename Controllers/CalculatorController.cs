using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
        {
            var result = a + b;
            return Ok(new{a, b, result});
        }
        [HttpGet("sub")]
        public IActionResult GetSubs([FromQuery] int a, [FromQuery] int b)
        {
            var result = a - b;
            return Ok(new{a, b, result});
        }
        [HttpGet("mult")]
        public IActionResult Getmult([FromQuery] int a, [FromQuery] int b)
        {
            var result = a * b;
            return Ok(new{a, b, result});
        }
        [HttpGet("div")]
        public IActionResult Getdiv([FromQuery] int a, [FromQuery] int b)
        {
            if (b==0)
            {
                return BadRequest("No es posible dividirlo entre 0");
            }
            else
            {
                var result = a / b;
                return Ok(new{a, b, result});
            }
        }

    }
}


