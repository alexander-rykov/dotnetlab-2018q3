using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRP.Examples.ActiveRecord;

namespace SRPTests
{
  [TestClass]
  public class UserTests
  {
    [TestMethod]
    public void UserActiveRecordTest()
    {
      var db = new List<User>();
      User user = new User(db);

      user.AddNew("Tom",Guid.NewGuid());
      user.Save();

      Assert.AreEqual(db.Count,1);
    }
  }
}
