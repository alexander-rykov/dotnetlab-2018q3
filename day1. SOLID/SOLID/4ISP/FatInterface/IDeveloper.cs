using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ISP
{
  interface IDeveloper
  {
    void WriteCode();
    void Commit();
    void DoFrontend();
    void DoBackEnd();

  }

  //public class Developer : IDeveloper
  //{
  //  public void WriteCode()
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public void Commit()
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public void DoFrontend()
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public void DoBackEnd()
  //  {
  //    throw new NotImplementedException();
  //  }
  //}
}
