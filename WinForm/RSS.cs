using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Diagnostics;

namespace WinForm
{
    [Serializable]
    public class RSS: Iinterface
    {
        
        public string url { get; set; }
        public string namn { get; set; }
        public string antalAvsnitt { get; set; }
        public string tidsIntervall { get; set; }
        public string kategori { get; set; }
       

        public string PodcastNamn(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            return feed.Title.Text;
            

            //foreach(SyndicationItem item in feed.Items)
            //{
            //    Debug.WriteLine(item.Title.Text);
            //    Debug.WriteLine("->" + item.Summary.Text);
            //}
        }
        public string AntalAvsnitt(string url)
        {
            int antal = 0;
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            foreach(SyndicationItem item in feed.Items)
            {
                antal += 1;
            }
            string stringAntal = antal.ToString();
            return stringAntal;
        }
       
    }
}
