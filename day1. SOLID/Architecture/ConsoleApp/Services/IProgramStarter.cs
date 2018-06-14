using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.ViewModels;

namespace ConsoleApp.Services
{
  interface IProgramStarter
  {
    ICollection<ItemViewModel> GetAllItems();
    double GetSumOfDiscountFromAllItems();
  }
}
