using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace WinForm
{
    class SerializeraPodcast
    {
        public void Serializera(List<RSS> podcasts)
        {
            if (File.Exists("PodcastLista.xml"))
            {
                File.Delete("PodcastLista.xml");
            }
            FileStream fileStream = new FileStream("PodcastLista.xml", FileMode.Append, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<RSS>));
            using (fileStream)
            {
                xmlSerializer.Serialize(fileStream, podcasts);
            }
        }
        public List<RSS> DeserializeraLista()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<RSS>));
            using (FileStream fileStream = new FileStream("PodcastLista.xml", FileMode.Open, FileAccess.Read))
            {
                return (List<RSS>)xmlSerializer.Deserialize(fileStream);
            }
        }
    }
}
