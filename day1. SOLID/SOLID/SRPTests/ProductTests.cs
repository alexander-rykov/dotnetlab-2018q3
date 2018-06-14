using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRP.Examples.Validation;

namespace SRPTests
{
  [TestClass]
  public class ProductTests
  {
    [TestMethod]
    public void ProductWithoutPriceShouldBeInvalid()
    {
      Product product = new Product();
      product.Price = 0;

      var isValid = product.IsValid();

      Assert.IsFalse(isValid);
    }

    //[TestMethod]
    //public void ProductWithLessThen100PriceShouldBeInvalid()
    //{
    //  Product product = new Product();
    //  product.Price = 99;

    //  var isValid = product.IsValid(true);

    //  Assert.IsFalse(isValid);
    //}
  }
}
