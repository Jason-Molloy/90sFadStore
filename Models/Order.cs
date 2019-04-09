using System.Collections.Generic;

namespace beaniebabies.Models
{
  public class Order
  {
    public int Id { get; set; }

    //key is id, value is quantity
    public List<LineItem> Invoice { get; set; } = new List<LineItem>();
  }
}
