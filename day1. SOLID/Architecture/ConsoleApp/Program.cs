using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBll.Infrastructure;
using AppBll.Interfaces;
using ConsoleApp.Services;
using Ninject;

namespace ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      IKernel kernel = new StandardKernel(new ServiceModule());
    }

    //static void EnableNinject()
    //{
    //  IKernel kernel = new StandardKernel();
      
    //  kernel.Bind<IProgramStarter>().To<ProgramStarter>().WithConstructorArgument();
    //}
  }
}
