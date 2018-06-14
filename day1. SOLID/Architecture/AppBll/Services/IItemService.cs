using System.Collections.Generic;
using AppBll.DataTransferObjects;
using AppBll.Interfaces;
using AppDAL.Context;
using AppDAL.NewFolder1;

namespace AppBll.Services
{
  public class ItemService:IItemService
  {
    IItemRepository Database { get; set; }

    public ItemService(IItemRepository db)
    {
      Database = db;
    }

    public void AddItem(ItemDto item)
    {
      Item newItemitem = new Item {Price = item.Price};
      Database.Add(newItemitem);
      Database.Save();
    }

    public ItemDto GetItem(int id)
    {
      var item = Database.Get(id);
      var resultItem = new ItemDto
      {
        Price = item.Price,
        Id = item.Id
      };
      return resultItem;
    }

    public IEnumerable<ItemDto> GetItems()
    {
      var items = Database.GetAll();
      var result = new List<ItemDto>();
      foreach (var item in items)
      {
        result.Add(new ItemDto(){Id=item.Id,Price = item.Price});
      }

      return result;
    }

    public void Dispose()
    {
      Database.Dispose();
    }
  }
}
