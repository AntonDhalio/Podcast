using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Linq;
using System.ServiceModel.Syndication;

namespace WinForm
{
    class UppdateraPodcast
    {
        List<RSS> podcasts = new List<RSS>();
        public void UppdateraKortTimer()
        {
            
            if (File.Exists("PodcastLista.xml"))
            {
                int i = 0;
                SerializeraPodcast xmlSerializering = new SerializeraPodcast();
                podcasts = xmlSerializering.DeserializeraLista();

                foreach (var item in podcasts)
                {
                    if( item.tidsIntervall == "5 sekunder")
                    {
                        
                        
                    }
                    i++;
                }
            }
        }

    }
}
