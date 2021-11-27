using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
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
        public async Task LaddaListaAsync(Form1 form1)
        {
            await Task.Run(() =>
            {
                lista = new List<RSS>();
                if (File.Exists("PodcastLista.xml"))
                {
                    lista.Clear();
                    SerializeraPodcast serializeraPodcast = new SerializeraPodcast();
                    lista = serializeraPodcast.DeserializeraLista();
                    
                }
            });
        }
    }
}
