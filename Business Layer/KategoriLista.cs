using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class KategoriLista: IListor
    {
        public List<Kategori> lista { get; set; } 
        
       
        public void LaddaLista()
        {
            lista = new List<Kategori>();
            if (File.Exists("Kategorier.xml"))
            {
                lista.Clear();
                SerializeraKategori serializeraKategori = new SerializeraKategori();
                lista = serializeraKategori.DeserializeraLista();
                

            }
        }
        public async Task LaddaListaAsync()
        {
                await Task.Run(() =>
                {
                lista = new List<Kategori>();
                    if (File.Exists("Kategorier.xml"))
                    {
                        lista.Clear();
                        SerializeraKategori serializeraKategori = new SerializeraKategori();
                        lista = serializeraKategori.DeserializeraLista();
                    }
                });
        }
    }
}
