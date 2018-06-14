using AppBll.Interfaces;
using AppBll.Services;
using Ninject.Modules;

namespace WebApplication.Infrastructure
{
  public class ItemModule :NinjectModule
  {
    public override void Load()
    {
      Bind<IItemService>().To<ItemService>();
    }
  }
}