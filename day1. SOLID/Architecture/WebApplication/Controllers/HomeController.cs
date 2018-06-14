using System.Collections.Generic;
using System.Web.Mvc;
using AppBll.DataTransferObjects;
using AppBll.Interfaces;
using AutoMapper;
using WebApplication.Models;

namespace WebApplication.Controllers
{
  public class HomeController : Controller
  {
    IItemService itemService;

    public HomeController(IItemService itemService)
    {
      this.itemService = itemService;
    }

    public ActionResult Index()
    {
      itemService.AddItem(new ItemDto(){Id = 10,Price = 10});// added for test
      IEnumerable<ItemDto> bllItems = itemService.GetItems();
      var mapper = new MapperConfiguration(x => x.CreateMap<ItemDto, ItemViewModel>()).CreateMapper();
      var items = mapper.Map<IEnumerable<ItemDto>, List<ItemViewModel>>(bllItems);

      return View(items);
    }

    //public ActionResult About()
    //{
    //  ViewBag.Message = "Your application description page.";

    //  return View();
    //}

    //public ActionResult Contact()
    //{
    //  ViewBag.Message = "Your contact page.";

    //  return View();
    //}

    public class HighLevelClass
    {
      public void Method(ILowLevelClass lowLevelClass)
      {
        
      }
    }

    public interface ILowLevelClass
    {
      
    } 

    public class LowLevelClass
    {
      
    }
  }
}