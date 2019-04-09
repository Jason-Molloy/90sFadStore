using System.Collections.Generic;
using beaniebabies.Models;

namespace beaniebabies.DataBase
{

  public static class Data
  {
    public static List<BeanieBaby> Inventory = new List<BeanieBaby>()
        {
            new BeanieBaby(20193,"Jon Snow", "#Adorbz, #KnowsNothing", 5.84m),
            new BeanieBaby(21505, "White Rabbit", "follow him!!!!", 6.78m),
            new BeanieBaby(4598, "Rubble", "He'll be there on the double! No job to big no pup to small.", 15.34m)
        };

  }
}