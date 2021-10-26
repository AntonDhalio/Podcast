using System;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Diagnostics;
using System.Collections.Generic;

namespace RSSFeed
{
    public class XmlHanterare
    {
        public class RSS
        {
            public static void FileStreamer()
            {
                XmlReader reader = XmlReader.Create("https://api.sr.se/api/rss/pod/22209");
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                Debug.WriteLine("Title: " + feed.Title.Text);
                Debug.WriteLine("Description: " + feed.Description.Text);
            }
        }

    }
}
}
