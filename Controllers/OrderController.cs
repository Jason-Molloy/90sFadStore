using beaniebabies.Models;
using Microsoft.AspNetCore.Mvc;

namespace beaniebabies.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class OrdersController : ControllerBase
  {
    [HttpPost]
    public ActionResult<Receipt> NewOrder([FromBody] Order order)
    {
      //backend check inventory, blah blah blah
      return new Receipt(order);

    }
  }
}