using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CubeController : ControllerBase
    {
        // GET api/cube
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Welcome to the Cube API!";
        }

        // GET api/cube/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"You requested cube with id: {id}";
        }

        // POST api/cube
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/cube/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/cube/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}