using MinutoSeguros.TesteMarcelo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MinutoSeguros.TesteMarcelo.Infrastructure
{
    public class BlogData : IBlogData
    { 

        public List<Blog> ListarBlogRepositorio(string feed)
        {
            XDocument xml = XDocument.Parse(feed);

            var RSSFeedData = (from x in xml.Descendants("item")
                               select new Blog
                               {
                                   Title = ((string)x.Element("title")),
                                   Link = ((string)x.Element("link")),
                                   Description = ((string)x.Element("description")),
                                   PubDate = DateTime.Parse(((string)x.Element("pubDate")))
                               });

            return RSSFeedData.ToList();
        }
    }
}
