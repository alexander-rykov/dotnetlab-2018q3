using System.Collections.Generic;
using AppDAL.Context;
using AppDAL.NewFolder1;

namespace AppDAL.Repositories
{
  public class ItemRepository:IItemRepository
  {
    private ItemContext db;

    //public ItemRepository(ItemContext db)
    public ItemRepository()
    {
      this.db = new ItemContext();
    }

    public IEnumerable<Item> GetAll()
    {
      return this.db.Items;
    }

    public Item Get(int id)
    {
      return this.db.Items.Find(id);
    }

    public Item Add(Item item)
    {
      this.db.Items.Add(item);
      return item;
    }

    public void Save()
    {
      this.db.SaveChanges();
    }

    public void Dispose()
    {
      db?.Dispose();
    }
  }
}
