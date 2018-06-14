using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3LSP;

namespace _3LSPTests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void CheckBehaviourForRegularList()
    {
      IList<int> list = new List<int>();

      list.Add(1);

      Assert.Equals(1, list.Count);
    }

    [TestMethod]
    public void CheckBehaviourForDoubleList()
    {
      IList<int> list = new DoubleList<int>();

      list.Add(1);

      Assert.Equals(1, list.Count); // fail
    }

    //[TestMethod]
    //public void ExceptionsTest()
    //{
    //  BaseClass obj = new BaseClass();

    //  try
    //  {
    //    obj.Method(10);
    //  }
    //  catch (ApplicationException e)
    //  {
    //    Console.WriteLine(e);
    //  }
    //}
  }
}
