using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WinForm
{
    class RssLista: IListor
    {
        public List<RSS> lista { get; set; }

        public void LaddaLista(Form1 form1)
        {
            lista = new List<RSS>();
            if (File.Exists("PodcastLista.xml"))
            {
                lista.Clear();
                SerializeraPodcast serializeraPodcast = new SerializeraPodcast();
                lista = serializeraPodcast.DeserializeraLista();
                form1.UppdateraListView();
            }
        }
    }
}
