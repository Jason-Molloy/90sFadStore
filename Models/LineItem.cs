using System.ComponentModel.DataAnnotations;

namespace beaniebabies.Models
{
  public class LineItem
  {
    public int Id { get; set; }
    [Range(1, 15)]
    public int Quantity { get; set; }
  }
}