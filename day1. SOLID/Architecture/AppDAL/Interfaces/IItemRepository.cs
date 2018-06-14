using System;
using System.Collections.Generic;
using AppDAL.NewFolder1;

namespace AppDAL.Context
{
  public interface IItemRepository: IDisposable
  {
    IEnumerable<Item> GetAll();
    Item Get(int id);
    Item Add(Item item);
    void Save();
  }
}
