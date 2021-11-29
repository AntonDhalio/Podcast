using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class RssLista: IListor
    {
        public List<RSS> lista { get; set; }
        

        public void LaddaLista()
        {
            lista = new List<RSS>();
            if (File.Exists("PodcastLista.xml"))
            {
                lista.Clear();
                SerializeraPodcast serializeraPodcast = new SerializeraPodcast();
                lista = serializeraPodcast.DeserializeraLista();
                
            }
        }
        public async Task LaddaListaAsync()
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
