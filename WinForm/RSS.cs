using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Diagnostics;

namespace WinForm
{
    public class RSS
    {
              
        public void FileStreamer(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            Debug.WriteLine("Title: " + feed.Title.Text);
            Debug.WriteLine("Description: " + feed.Description.Text);

            foreach(SyndicationItem item in feed.Items)
            {
                Debug.WriteLine(item.Title.Text);
                Debug.WriteLine("->" + item.Summary.Text);
            }
        }
        
    }
}
