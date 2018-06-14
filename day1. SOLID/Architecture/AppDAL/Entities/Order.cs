using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDAL.NewFolder1
{
  public class Order
  {
    public int Id { get; set; }
    
    public ICollection<Item> Items { get; set; }
  }
}
