using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    class KategoriLista: IListor
    {
        public List<Data_Layer.Kategori> lista { get; set; } 
        
       
        public void LaddaLista(Form1 form1)
        {
            lista = new List<Data_Layer.Kategori>();
            if (File.Exists("Kategorier.xml"))
            {
                lista.Clear();
                Data_Layer.SerializeraKategori serializeraKategori = new SerializeraKategori();
                lista = serializeraKategori.DeserializeraLista();
                form1.UppdateralbKategorier();
                form1.UppdateraCbKategorier();

            }
        }
        public async Task LaddaListaAsync(Form1 form1)
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
