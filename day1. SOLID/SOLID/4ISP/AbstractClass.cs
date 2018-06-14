using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ISP
{
  // чрезмерная абстракция заменяется на виртуализацию.
  public class DeveloperBase
  {
    public virtual void WriteCode()
    {
      // write code
    }
  }

  public abstract class DotNetDeveloper:DeveloperBase
  {
    public override void WriteCode()
    {
      this.OpenVisualStudio();
      this.DoSomething();
      //this.CommitChanges();
    }

    public abstract void OpenVisualStudio();
    public abstract void DoSomething();

    //public abstract void CommitChanges();
  }

  public class BackendDeveloper : DotNetDeveloper
  {
    public override void OpenVisualStudio()
    {
      throw new NotImplementedException();
    }

    public override void DoSomething()
    {
      throw new NotImplementedException();
    }
  }

  public class FullstackDeveloper : DotNetDeveloper
  {
    public override void OpenVisualStudio()
    {
      throw new NotImplementedException();
    }

    public override void DoSomething()
    {
      throw new NotImplementedException();
    }
  }


}
