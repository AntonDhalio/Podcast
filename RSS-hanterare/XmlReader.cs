using System;
using System.IO;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Xml;

namespace System.ServiceModel.Syndication
{
    public class RSS
    {
        public static void FileStreamer()
        {
            XmlReader reader = XmlReader.Create("https://api.sr.se/api/rss/pod/22209");
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            Debug.WriteLine("Title: " + feed.Title.Text);
            Debug.WriteLine("Description: " + feed.Des.Text);
        }
    }
    
}
