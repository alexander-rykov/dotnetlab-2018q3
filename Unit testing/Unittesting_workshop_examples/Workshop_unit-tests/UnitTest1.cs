using System;
using NUnit.Framework;
using Unittesting_workshop_examples;

namespace Workshop_unit_tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var service = new TutByFinanceNewsService();
            var result = service.StoreNews("https://news.tut.by/rss/finance.rss");
        }
    }
}
