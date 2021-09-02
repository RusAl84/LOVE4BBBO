using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class InalController : ControllerBase
  {
    // GET: api/<InalController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "Инал", "хочет в Кабул" };
    }

    // GET api/<InalController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "Инал съел " + id.ToString() + " Ёжиков";
    }

    // POST api/<InalController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<InalController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<InalController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
