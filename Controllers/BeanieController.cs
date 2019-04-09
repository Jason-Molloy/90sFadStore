using System.Collections.Generic;
using beaniebabies.DataBase;
using beaniebabies.Models;
using Microsoft.AspNetCore.Mvc;

namespace beaniebabies.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BeanieController : ControllerBase
  {
    //BAD DONT DO THIS
    List<BeanieBaby> Inventory = Data.Inventory;

    // GET ALL api/beanie
    [HttpGet]
    public ActionResult<List<BeanieBaby>> Get()
    {
      return Inventory;
    }

    //Get by Id 
    [HttpGet("{id}")]
    public ActionResult<BeanieBaby> GetById(int id)
    {
      BeanieBaby found = Inventory.Find(b => b.Id == id);
      if (found != null)
      {
        return found;
      }
      return BadRequest("{\"error\": \"not found\"}");
    }

    [HttpPost]
    public ActionResult<List<BeanieBaby>> Post([FromBody] BeanieBaby value)
    {
      Inventory.Add(value);
      return Inventory;
    }

    // api/beanie/:id
    [HttpPut("{id}")]
    public ActionResult<BeanieBaby> Put(int id, [FromBody] BeanieBaby newData)
    {
      //add newData inplace of old
      BeanieBaby oldData = Inventory.Find(b => b.Id == id);
      if (oldData == null) { return BadRequest(); }
      Inventory.Remove(oldData);
      Inventory.Add(newData);
      return newData;
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      BeanieBaby oldData = Inventory.Find(b => b.Id == id);
      if (oldData == null) { return BadRequest(); }
      Inventory.Remove(oldData);
      return Ok();
    }
  }
}