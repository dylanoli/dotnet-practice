using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(float firstNumber, float secondNumber)
        {
            return Ok((firstNumber + secondNumber).ToString());
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(float firstNumber, float secondNumber)
        {
            return Ok((firstNumber - secondNumber).ToString());
        }

        [HttpGet("multiply/{firstNumber}/{secondNumber}")]
        public IActionResult Multiply(float firstNumber, float secondNumber)
        {
            return Ok((firstNumber * secondNumber).ToString());
        }

        [HttpGet("divide/{firstNumber}/{secondNumber}")]
        public IActionResult Divide(float firstNumber, float secondNumber)
        {
            return Ok((firstNumber * secondNumber).ToString());
        }

        [HttpGet("avg/{firstNumber}/{secondNumber}")]
        public IActionResult Average(float firstNumber, float secondNumber)
        {
            return Ok(((firstNumber + secondNumber) / 2).ToString());
        }

        [HttpGet("sqrt/{number}")]
        public IActionResult SquadRoot(float number)
        {
            return Ok(Math.Sqrt(number).ToString());
        }
    }
}
