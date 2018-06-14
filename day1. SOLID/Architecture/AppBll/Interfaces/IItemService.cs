using System.Collections.Generic;
using AppBll.DataTransferObjects;

namespace AppBll.Interfaces
{
  public interface IItemService
  {
    void AddItem(ItemDto item);
    ItemDto GetItem(int id);
    IEnumerable<ItemDto> GetItems();
    void Dispose();
  }
}
