using System.Collections.Generic;
using AppBll.BusinessModels;
using AppBll.Interfaces;
using ConsoleApp.ViewModels;

namespace ConsoleApp.Services
{
  public class ProgramStarter
  {
    private IItemService _itemService;
    private IDiscounter _discounter;

    public ProgramStarter(IItemService itemService, IDiscounter discounter)
    {
      this._itemService = itemService;
      this._discounter = discounter;
    }

    public ICollection<ItemViewModel> GetAllItems()
    {
      var items = _itemService.GetItems();
      var result = new List<ItemViewModel>();
      foreach (var item in items)
      {
        result.Add(new ItemViewModel { Id=item.Id, Price = item.Price});
      }

      return result;
    }

    public double GetSumOfDiscountFromAllItems()
    {
      var items = _itemService.GetItems();
      double sum = 0;
      foreach (var item in items)
      {
        sum += item.Price;
      }

      var discount = _discounter.GetSumOfDiscount(sum);

      return discount;
    }
  }
}
