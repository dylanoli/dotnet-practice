using api.Models;
using api.Services;
using api.Services.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _service;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, IUserService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(_service.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult FindById(long id)
        {
            var user = _service.FindById(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            return Ok(_service.Create(user));
        }

        [HttpPut]
        public IActionResult Update([FromBody] User user)
        {
            return Ok(_service.Update(user));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _service.Delete(id);
            return Ok();
        }

    }
}