using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;

namespace Unittesting_workshop_examples
{
    public class RssService
    {
        public IEnumerable<RssModel> GetRss(string url)
        {
            using (var reader = XmlReader.Create(url))
            {
                var feed = SyndicationFeed.Load(reader);

                return feed.Items.Select(item => new RssModel
                {
                    Title = item.Title.Text,
                    Description = item.Summary.Text,
                    Link = item.Links.FirstOrDefault()?.Uri,
                    PublishDate = item.PublishDate.Date
                });
            }
        }
    }
}
