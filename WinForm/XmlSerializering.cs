﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace WinForm
{
    class XmlSerializering
    {
        public virtual void Serializera(List<object> enLista, String sokVag)
        {
            if (File.Exists(sokVag))
            {
                File.Delete(sokVag);
            }
            FileStream fileStream = new FileStream(sokVag, FileMode.Append, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<object>));
            using (fileStream)
            {
                xmlSerializer.Serialize(fileStream, enLista);
            }
        }
        public virtual List<object> DeserializeraLista(String sokVag)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<object>));
            using (FileStream fileStream = new FileStream(sokVag, FileMode.Open, FileAccess.Read))
            {
                return (List<object>)xmlSerializer.Deserialize(fileStream);
            }
        }
    }
}
