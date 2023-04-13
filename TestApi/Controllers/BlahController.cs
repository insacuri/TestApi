using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlahController : ControllerBase
{
    // GET: api/blah
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new[] { "value1", "value2" };
    }

    // GET: api/blah/5
    [HttpGet("{id}", Name = "Get")]
    [ProducesResponseType(404)]
    [ProducesResponseType(200)]
    public IActionResult Get(int id)
    {
        if (id == 2) return Ok("Here's your item");
        return NotFound("blah");
    }

    // POST: api/blah
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT: api/blah/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE: api/blah/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}