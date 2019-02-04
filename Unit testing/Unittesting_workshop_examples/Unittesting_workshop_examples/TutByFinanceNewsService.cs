using System;
using System.Collections.Generic;
using System.Linq;

namespace Unittesting_workshop_examples
{
    public class TutByFinanceNewsService
    {
        private const string Host = "finance.tut.by";

        public IEnumerable<RssModel> StoreNews(string url)
        {
            var objectBroker = new InMemoryObjectBroker();
            var rssService = new RssService();

            var modelsToStore = rssService.GetRss(url).ToList();

            // validation
            if (modelsToStore.Any(rssModel => rssModel.Link.Host != Host))
            {
                throw new Exception("Wrong host");
            }

            foreach (var rssModel in modelsToStore)
            {
                objectBroker.Add(rssModel);
            }

            return modelsToStore;
        }
    }
}