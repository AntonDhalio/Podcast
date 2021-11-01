using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace WinForm
{
    class SerializeraKategori: XmlSerializering
    {
        public void Serializera(Kategori kategori)
        {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Kategori));
                using (FileStream fileStream = new FileStream("Kategorier.xml", FileMode.Append, FileAccess.Write))
                {
                    xmlSerializer.Serialize(fileStream, kategori);
                }
        }

        public Kategori Deserializera()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Kategori));
            using (FileStream fileStream = new FileStream("Kategorier.xml", FileMode.Open, FileAccess.Read))
            {
                return (Kategori)xmlSerializer.Deserialize(fileStream);
            }
        }

        public void Serializera (List<Kategori> kategorier)
        {
            if (File.Exists("Kategorier.xml"))
            {
                File.Delete("Kategorier.xml");
            }
            FileStream fileStream = new FileStream("Kategorier.xml", FileMode.Append, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
            using (fileStream)
            {
                xmlSerializer.Serialize(fileStream, kategorier);
            }
        }
        public List<Kategori> DeserializeraLista()
        {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
                using (FileStream fileStream = new FileStream("Kategorier.xml", FileMode.Open, FileAccess.Read))
                {
                    return (List<Kategori>)xmlSerializer.Deserialize(fileStream);
                }
        }
    }
}
