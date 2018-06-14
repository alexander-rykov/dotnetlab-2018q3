using AppDAL.Context;
using AppDAL.Repositories;
using Ninject.Modules;

namespace AppBll.Infrastructure
{
  public class ServiceModule :NinjectModule
  {
    public override void Load()
    {
      Bind<IItemRepository>().To<ItemRepository>();
    }
  }
}
